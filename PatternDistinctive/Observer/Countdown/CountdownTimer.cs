using _3S_eShop.PatternDistinctive.Singleton;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Observer.Countdown
{
    /// <summary>
    /// Lớp tiện ích để tạo một bộ đếm ngược và thông báo định kỳ.
    /// Áp dụng Observer Pattern thông qua các sự kiện C#.
    /// Cần Dispose để giải phóng tài nguyên khi không dùng đến.
    /// Nếu không biết cách Dispose khi nào thì có thể Dispose ngay lúc đóng Form (sự kiện FormClosed) hoặc UserControl (override Dispose). 
    /// </summary>
    public class CountdownTimer : IDisposable
    {
        private readonly int _totalSeconds;
        private readonly int _notifyIntervalSeconds;
        private CancellationTokenSource _cts;
        private Task _countdownTask;
        private int _currentSeconds;
        private bool _isCancelled = false;
        private bool _isRunning = false;
        private readonly object _lock = new object(); // Để đảm bảo Start/Cancel thread-safe

        /// <summary>
        /// Sự kiện được kích hoạt khi bộ đếm ngược bắt đầu.
        /// </summary>
        public event EventHandler<CountdownEventArgs> OnStart;

        /// <summary>
        /// Sự kiện được kích hoạt định kỳ sau mỗi khoảng thời gian notifyIntervalSeconds.
        /// </summary>
        public event EventHandler<CountdownEventArgs> OnNotify;

        /// <summary>
        /// Sự kiện được kích hoạt khi bộ đếm ngược bị hủy bỏ bởi phương thức Cancel().
        /// </summary>
        public event EventHandler<CountdownEventArgs> OnCancel;

        /// <summary>
        /// Sự kiện được kích hoạt khi bộ đếm ngược kết thúc (hoàn thành hoặc bị hủy).
        /// Luôn được gọi sau cùng.
        /// </summary>
        public event EventHandler<CountdownEventArgs> OnFinal;

        /// <summary>
        /// Khởi tạo một đối tượng CountdownTimer mới.
        /// </summary>
        /// <param name="totalSeconds">Tổng số giây cần đếm ngược. Phải lớn hơn 0.</param>
        /// <param name="notifyIntervalSeconds">Số giây giữa các lần thông báo. Phải lớn hơn 0 và nhỏ hơn hoặc bằng totalSeconds.</param>
        /// <exception cref="ArgumentOutOfRangeException">Ném ra nếu các tham số không hợp lệ.</exception>
        public CountdownTimer(int totalSeconds, int notifyIntervalSeconds)
        {
            if (totalSeconds <= 0)
                throw new ArgumentOutOfRangeException(nameof(totalSeconds), "Tổng số giây phải lớn hơn 0.");
            if (notifyIntervalSeconds <= 0)
                throw new ArgumentOutOfRangeException(nameof(notifyIntervalSeconds), "Khoảng thời gian thông báo phải lớn hơn 0.");
            if (notifyIntervalSeconds > totalSeconds)
                throw new ArgumentOutOfRangeException(nameof(notifyIntervalSeconds), "Khoảng thời gian thông báo không được lớn hơn tổng số giây.");

            _totalSeconds = totalSeconds;
            _notifyIntervalSeconds = notifyIntervalSeconds;
            _currentSeconds = _totalSeconds; // Khởi tạo trạng thái ban đầu
        }

        /// <summary>
        /// Bắt đầu quá trình đếm ngược.
        /// </summary>
        /// <exception cref="InvalidOperationException">Ném ra nếu bộ đếm ngược đang chạy.</exception>
        public void Start()
        {
            lock (_lock)
            {
                if (_isRunning)
                {
                    // Có thể chọn throw exception hoặc chỉ return tùy theo yêu cầu
                    Console.WriteLine("CountdownTimer is already running.");
                    // throw new InvalidOperationException("Countdown timer is already running.");
                    return;
                }

                _cts = new CancellationTokenSource();
                _isCancelled = false;
                _currentSeconds = _totalSeconds; // Reset lại giây khi bắt đầu
                _isRunning = true; // Đánh dấu đang chạy

                // Chạy task đếm ngược trong background
                _countdownTask = RunCountdownAsync(_cts.Token);
            }
        }

        /// <summary>
        /// Hủy bỏ quá trình đếm ngược đang diễn ra.
        /// </summary>
        public void Cancel()
        {
            lock (_lock)
            {
                if (!_isRunning || _cts == null || _cts.IsCancellationRequested)
                {
                    // Không chạy hoặc đã bị hủy rồi thì không làm gì
                    return;
                }
                _isCancelled = true; // Đánh dấu là bị hủy bởi người dùng
                _cts.Cancel(); // Gửi tín hiệu hủy
            }
            // Không cần chờ task kết thúc ở đây, việc xử lý sẽ nằm trong RunCountdownAsync
        }

        private async Task RunCountdownAsync(CancellationToken cancellationToken)
        {
            try
            {
                // --- OnStart ---
                double startPercent = _totalSeconds > 0 ? 100.0 : 0.0;
                // Gán _currentSeconds trước khi gọi event
                _currentSeconds = _totalSeconds;
                SafeInvoke(OnStart, new CountdownEventArgs(_currentSeconds, startPercent));

                int elapsedSeconds = 0;

                while (_currentSeconds > 0)
                {
                    // Chờ 1 giây hoặc đến khi có yêu cầu hủy
                    await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);

                    // Sau khi chờ, kiểm tra lại lần nữa phòng trường hợp bị cancel ngay lúc đang chờ
                    cancellationToken.ThrowIfCancellationRequested();

                    _currentSeconds--;
                    elapsedSeconds++;

                    double percentLeft = _totalSeconds > 0 ? (double)_currentSeconds / _totalSeconds * 100.0 : 0.0;

                    // --- OnNotify ---
                    // Thông báo nếu đến đúng khoảng lặp VÀ chưa phải giây cuối cùng (vì OnFinal sẽ xử lý giây cuối)
                    if (_currentSeconds > 0 && elapsedSeconds % _notifyIntervalSeconds == 0)
                    {
                        SafeInvoke(OnNotify, new CountdownEventArgs(_currentSeconds, percentLeft));
                    }

                    // Nếu đếm về 0, thoát vòng lặp để kích hoạt OnFinal
                    if (_currentSeconds <= 0)
                    {
                        break;
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Bắt exception khi Task.Delay bị hủy bởi cancellationToken
                // --- OnCancel ---
                // Chỉ kích hoạt OnCancel nếu nó bị hủy bởi phương thức Cancel()
                if (_isCancelled)
                {
                    double percentLeft = _totalSeconds > 0 ? (double)_currentSeconds / _totalSeconds * 100.0 : 0.0;
                    SafeInvoke(OnCancel, new CountdownEventArgs(_currentSeconds, percentLeft));
                }
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi không mong muốn khác nếu cần
                Console.WriteLine($"An error occurred during countdown: {ex.Message}");
                Logger.Instance.LogErrorException(ex, "COUNT DOWN TIMER - Lỗi không mong muốn trong bộ đếm ngược");
            }
            finally
            {
                // --- OnFinal ---
                // Luôn được gọi dù kết thúc bình thường hay bị hủy
                // Đảm bảo _currentSeconds là 0 nếu kết thúc bình thường
                if (!_isCancelled) _currentSeconds = 0;
                double finalPercent = _totalSeconds > 0 ? (double)_currentSeconds / _totalSeconds * 100.0 : 0.0;
                SafeInvoke(OnFinal, new CountdownEventArgs(_currentSeconds, finalPercent));

                // Dọn dẹp và reset trạng thái
                DisposeCts();
                lock (_lock) // Đảm bảo reset _isRunning an toàn
                {
                    _isRunning = false;
                    _countdownTask = null;
                }
            }
        }

        /// <summary>
        /// Gọi sự kiện một cách an toàn (kiểm tra null).
        /// </summary>
        private void SafeInvoke(EventHandler<CountdownEventArgs> handler, CountdownEventArgs args)
        {
            // Sử dụng ?.Invoke để tránh NullReferenceException nếu không có ai đăng ký sự kiện
            try
            {
                handler?.Invoke(this, args);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi từ các event handler nếu cần, để tránh làm sập bộ đếm ngược
                Console.WriteLine($"Error in event handler: {ex.Message}");
                Logger.Instance.LogErrorException(ex, "COUNTDOWN TIMER - Lỗi không mong muốn trong sự kiện");
            }
        }

        /// <summary>
        /// Giải phóng CancellationTokenSource.
        /// </summary>
        private void DisposeCts()
        {
            _cts?.Dispose();
            _cts = null;
        }

        /// <summary>
        /// Giải phóng tài nguyên (CancellationTokenSource).
        /// </summary>
        public void Dispose()
        {
            Cancel(); // Đảm bảo hủy task nếu đang chạy
            DisposeCts();
            GC.SuppressFinalize(this); // Thông báo cho GC không cần gọi Finalizer
        }

        // Optional: Finalizer để đảm bảo CTS được dispose nếu quên gọi Dispose()
        // Tuy nhiên, nên ưu tiên sử dụng using hoặc gọi Dispose() rõ ràng
         ~CountdownTimer()
        {
            DisposeCts();
        }
    }
}
