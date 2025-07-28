using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.State
{
    public class NotConfirmedState : IConfirmationState
    {
        public void Confirm(ConfirmHandler context)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] State: NotConfirmed -> Handling Confirm.");
            context.OnConfirming?.Invoke(); // Gọi hành động trước khi đổi state

            // Chuyển sang trạng thái Confirmed
            context.TransitionTo(new ConfirmedState());

            // Hành động sau khi đã chuyển state (bao gồm cả việc start timer)
            context.StartResetTimer(); // Yêu cầu context bắt đầu timer
            context.OnConfirmed?.Invoke();
        }

        public void HandleTimeout(ConfirmHandler context)
        {
            // Không làm gì khi đang ở trạng thái chưa xác nhận mà timer hết hạn
            // (Vì timer chỉ chạy khi ở trạng thái Confirmed)
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] State: NotConfirmed -> Ignoring Timeout (Timer shouldn't be running).");
        }
    }

}
