namespace _3S_eShop.PatternDistinctive.Observer.EditUserInfomation
{
    public interface IObserver
    {
        void Update(string information, int state);
        // Phương thức này sẽ được gọi khi có sự thay đổi trong Subject
        // Các observer sẽ thực hiện hành động tương ứng với sự thay đổi
    }
}