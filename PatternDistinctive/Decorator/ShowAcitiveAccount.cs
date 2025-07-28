using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Decorator
{
    public class ShowAcitiveAccount : FilterDecorator
    {
        public ShowAcitiveAccount(IUser user) : base(user)
        {
        }

        
        public override DataTable GetUserList(int page, int pageSize, out int totalRecords, string additionalWhereClause = null)
        {
            // Chèn điều kiện active
            var where = "is_active = 1";
            if (!string.IsNullOrWhiteSpace(additionalWhereClause))
                where += $" AND ({additionalWhereClause})";

            return user.GetUserList(page, pageSize, out totalRecords, where);
        }
    }
}
