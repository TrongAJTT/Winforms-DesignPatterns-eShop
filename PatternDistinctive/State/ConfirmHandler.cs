using System;
using System.Timers;

namespace _3S_eShop.PatternDistinctive.State
{
    public class ConfirmHandler : IDisposable
    {
        private IConfirmationState _currentState;
        private readonly object _lock = new object();
        private readonly int _timeoutSeconds;
        private Timer _resetTimer;

        /// <summary>
        /// Hành động được thực thi KHI trạng thái đang từ "chưa xác nhận"
        /// CHUẨN BỊ chuyển sang "đã xác nhận".
        /// Được gọi trước khi trạng thái thực sự thay đổi.
        /// </summary>
        public Action OnConfirming { get; set; }

        /// <summary>
        /// Hành động được thực thi NGAY SAU KHI trạng thái
        /// ĐÃ chuyển sang "đã xác nhận".
        /// </summary>
        public Action OnConfirmed { get; set; }

        /// <summary>
        /// Hành động được thực thi khi gọi Confirm() nhưng trạng thái
        /// ĐÃ LÀ "đã xác nhận" và chưa hết thời gian chờ.
        /// </summary>
        public Action OnAlreadyConfirmed { get; set; }

        /// <summary>
        /// Hành động được thực thi khi trạng thái tự động quay về "chưa xác nhận"
        /// do hết thời gian chờ.
        /// </summary>
        public Action OnResetDueToTimeout { get; set; }

        /// <summary>
        /// Khởi tạo ConfirmHandler.
        /// </summary>
        /// <param name="timeoutSeconds">Số giây trạng thái "đã xác nhận" tồn tại
        /// trước khi tự động quay về "chưa xác nhận". Phải lớn hơn 0.</param>
        /// <exception cref="ArgumentOutOfRangeException">Ném ra nếu timeoutSeconds <= 0.</exception>
        public ConfirmHandler(int timeoutSeconds)
        {
            if (timeoutSeconds <= 0) throw new ArgumentOutOfRangeException(nameof(timeoutSeconds));
            _timeoutSeconds = timeoutSeconds;
            InitializeTimer();
            // Trạng thái ban đầu là NotConfirmed
            _currentState = new NotConfirmedState();
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Handler: Initialized in NotConfirmed state.");
        }

        private void InitializeTimer()
        {
            _resetTimer = new Timer(_timeoutSeconds * 1000);
            _resetTimer.Elapsed += HandleTimerElapsed; // Timer vẫn gọi về Handler
            _resetTimer.AutoReset = false;
            _resetTimer.Enabled = false;
        }

        // Phương thức chuyển trạng thái (quan trọng)
        internal void TransitionTo(IConfirmationState newState)
        {
            lock (_lock) // Đảm bảo việc chuyển state là an toàn
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Handler: Transitioning from {_currentState.GetType().Name} to {newState.GetType().Name}");
                _currentState = newState;
                // Có thể thêm logic Enter/Exit state ở đây nếu cần
            }
        }

        /// <summary>
        /// Xử lý yêu cầu xác nhận.
        /// Hành vi phụ thuộc vào trạng thái hiện tại.
        /// </summary>
        public void Confirm()
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Handler: Confirm() called. Delegating to {_currentState.GetType().Name}");
            // Lock có thể cần thiết ở đây hoặc trong state, tùy thuộc vào mức độ phức tạp
            // và tài nguyên được chia sẻ. Ở đây để đơn giản, state sẽ không cần lock.
            lock (_lock)
            {
                _currentState.Confirm(this); // Truyền 'this' làm context
            }
        }

        private void HandleTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Handler: Timer Elapsed. Delegating to {_currentState.GetType().Name}");
            lock (_lock) // Đảm bảo thread-safe khi timer kích hoạt
            {
                // Timer đã dừng (AutoReset=false).
                // Ủy thác xử lý timeout cho state hiện tại.
                _currentState.HandleTimeout(this);
            }
        }

        // Hàm để các state có thể điều khiển timer thông qua context
        internal void StartResetTimer()
        {
            lock (_lock)
            {
                _resetTimer?.Stop();
                _resetTimer?.Start();
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Handler: Reset timer started ({_timeoutSeconds}s) by state request.");
            }
        }

        // Sẽ cần đối với logic dừng timer sớm
        internal void StopResetTimer()
        {
            lock (_lock)
            {
                _resetTimer?.Stop();
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Handler: Reset timer stopped by state request.");
            }
        }

        // IsConfirmed kiểm tra loại state
        public bool IsConfirmed => _currentState is ConfirmedState;

        // Dispose để quản lý Timer
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_resetTimer != null)
                {
                    _resetTimer.Stop();
                    _resetTimer.Elapsed -= HandleTimerElapsed;
                    _resetTimer.Dispose();
                    _resetTimer = null;
                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] Handler: Timer disposed.");
                }
            }
        }
    }


}
