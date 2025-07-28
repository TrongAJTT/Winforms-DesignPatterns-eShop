using _3S_eShop.Connect;
using _3S_eShop.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Observer.EditUserInfomation
{
    internal class SendUserOTP : IProcessing
    {
        private List<IObserver> observers;
        private string information;
        private int state; // 0: Đang gửi mã OTP, 1: Đã gửi mã OTP thành công, 2: gửi mã thất bại, 3: sắp hết thời gian, 4: đã hết thời gian
        public SendUserOTP()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(information, state);
            }
        }

        public void SetInformation(string information, int state)
        {
            this.information = information;
            this.state = state;
            NotifyObservers();
        }

        public async Task<bool> createOTP(string email)
        {
            SetInformation("Đang gửi mã OTP", 0);
            Random random = new Random();
            int otp = random.Next(100000, 999999);
            var t1 = EmailHandler.sendOTPEditEmailAsync(email, otp.ToString());
            await t1.ConfigureAwait(false);
            if (t1.IsFaulted)
            {
                SetInformation("Gửi mã OTP thất bại", 2);
                return false;
            }
            SetInformation("Đã gửi mã OTP thành công, vui lòng check email", 1);
            return true;
        }

        public async void timeOut()
        {
            int timeOut = 5 * 60; // 5 phút
            SetInformation($"Thời gian còn lại {timeOut}", state: 1);
            while (timeOut > 0)
            {
                await Task.Delay(1000);
                timeOut--;
                if(timeOut < 10)
                {
                   SetInformation($"Thời gian còn lại {timeOut}", state: 3);
                }
                SetInformation($"Thời gian còn lại {timeOut}", state: 1);
            }
            SetInformation("Mã OTP đã hết thời gian, vui lòng xác thực lại", 4);
        }
    }
}
