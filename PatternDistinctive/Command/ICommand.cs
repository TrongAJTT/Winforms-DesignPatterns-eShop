using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Command
{
    public interface ICommand<T>
    {
        T Execute();
    }
}
