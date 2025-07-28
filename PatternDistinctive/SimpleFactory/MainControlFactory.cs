using _3S_eShop.GUI;
using _3S_eShop.GUI.MainControls;
using _3S_eShop.GUI.MainControls.Auth;
using _3S_eShop.GUI.Test;
using System.Windows.Forms;

namespace _3S_eShop.PatternDistinctive.SimpleFactory
{
    public class MainControlFactory
    {

        public MainControlFactory()
        {
        }
        public UserControl CreateUserControl(Type type)
        {
            if(type == Type.Home)
            {
                return new HomeControl();
            }
            if(type == Type.Category)
            {
                return new CategoryControl();
            }
            if(type == Type.Browse)
            {
                return new BrowseControl();
            }
            if (type == Type.Cart)
            {
                return new CartControl();
            }
            if(type == Type.User)
            {
                 return new UserProfileControl();
            }
            if( type == Type.Setting)
            {
                return new SettingControl();
            }
            if (type == Type.Admin)
            {
                return new AdminControl();
            }
            if (type == Type.Login)
            {
                return new LoginControl();
            }
            if(type == Type.NoInternet)
            {
                return new NoInternetControl();
            }
            return null;
        }

        public enum Type
        {
            // 7 type đầu tương ứng với các control bên Main
            Home = 0,
            Category = 1,
            Browse = 2,
            Cart = 3,
            User = 4,
            Setting = 5,
            Admin = 6,
            Login = 7,
            NoInternet = 8,
        }

    }
}
