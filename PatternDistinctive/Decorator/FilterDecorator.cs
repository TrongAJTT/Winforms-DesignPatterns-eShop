using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Decorator
{
    public abstract class FilterDecorator : IUser
    {
        protected IUser user;

        public FilterDecorator(IUser user)
        {
            this.user = user;
        }

        public abstract DataTable GetUserList(int page, int pageSize, out int totalRecords, string additionalWhereClause = null);
    }
}
