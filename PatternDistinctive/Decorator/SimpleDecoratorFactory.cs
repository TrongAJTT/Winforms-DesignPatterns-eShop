using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Decorator
{
    public class SimpleDecoratorFactory
    {
        public static IUser CreateUser(string type, IUser user)
        {
            switch (type)
            {
                case "active":
                    return new ShowAcitiveAccount(user);
                case "Ban":
                    return new ShowBanAccount(user);
                case "Online":
                    return new ShowOnlSixMonthLatest(user);
                case "Decreasing":
                    return new Decreasing(user);
                default:
                    return user;
            }
        }
    }
}
