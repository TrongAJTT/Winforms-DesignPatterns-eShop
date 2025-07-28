using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Decorator
{
    public class Decreasing : FilterDecorator
    {
        public Decreasing(IUser user) : base(user)
        {
        }

        public override DataTable GetUserList(int page, int pageSize, out int totalRecords, string additionalWhereClause = null)
        {
            var result = user.GetUserList(page, pageSize, out totalRecords, additionalWhereClause)
                 .AsEnumerable();

            var ordered = result.OrderByDescending(row => row.Field<long>("id"));
            return ordered.Any() ? ordered.CopyToDataTable() : result.CopyToDataTable().Clone();
        }
    }
   
}
