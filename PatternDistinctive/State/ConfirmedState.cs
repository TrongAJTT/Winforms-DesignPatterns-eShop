using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.State
{
    public class ConfirmedState : IConfirmationState
    {
        public void Confirm(ConfirmHandler context)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] State: Confirmed -> Handling Confirm (Already Confirmed).");
            context.OnAlreadyConfirmed?.Invoke(); // Gọi hành động khi đã xác nhận
                                                  // Không thay đổi trạng thái
        }

        public void HandleTimeout(ConfirmHandler context)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] State: Confirmed -> Handling Timeout.");
            // Chuyển về trạng thái Chưa xác nhận
            context.TransitionTo(new NotConfirmedState());
            context.OnResetDueToTimeout?.Invoke(); // Gọi hành động khi bị reset
        }
    }

}
