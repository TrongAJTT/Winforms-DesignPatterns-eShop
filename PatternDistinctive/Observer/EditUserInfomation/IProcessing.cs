using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Observer.EditUserInfomation
{
    internal interface IProcessing
    {
        void RegisterObserver(IObserver observer);
        // Đăng ký một observer
        void RemoveObserver(IObserver observer);
        // Hủy đăng ký một observer
        void NotifyObservers();
        // Thông báo cho tất cả các observer về sự thay đổis
    }
}
