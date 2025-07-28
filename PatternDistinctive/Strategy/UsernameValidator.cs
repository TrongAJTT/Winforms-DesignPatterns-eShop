namespace _3S_eShop.Validate
{
    internal class UsernameValidator: BaseValidator
    {
        public override bool IsValid(string text, params string[] param)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                invalidMessage = "Tên tài khoản không được để trống";
                return false;
            }

            // Tên tài khoản phải ít nhất 6 ký tự
            if (text.Length < 6){
                invalidMessage = "Tên tài khoản phải ít nhất 6 ký tự";
                return false;
            }

            return true;
        }
    }
}
