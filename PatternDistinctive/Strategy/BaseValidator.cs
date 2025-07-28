using System;

namespace _3S_eShop.Validate
{
    public abstract class BaseValidator
    {
        protected String invalidMessage;

        public abstract bool IsValid(string text, params string[] param);
        public String GetInvalidMessage()
        {
            return invalidMessage;
        }
    }
}