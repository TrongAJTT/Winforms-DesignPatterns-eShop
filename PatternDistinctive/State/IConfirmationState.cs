namespace _3S_eShop.PatternDistinctive.State
{
    public interface IConfirmationState
    {
        // Xử lý khi người dùng gọi Confirm()
        void Confirm(ConfirmHandler context);

        // Xử lý khi timer hết hạn (nếu có)
        void HandleTimeout(ConfirmHandler context);
    }
}
