using Google.Apis.Drive.v3.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Decorator
{
    public class ShowOnlSixMonthLatest : FilterDecorator
    {
        public ShowOnlSixMonthLatest(IUser user) : base(user)
        {
        }


        public override DataTable GetUserList(int page, int pageSize, out int totalRecords, string additionalWhereClause = null)
        {
            // Điều kiện 6 tháng gần đây, format yyyy-MM-dd an toàn cho SQL
            string recentFilter = $"last_login_date >= '{DateTime.Now.AddMonths(-6):yyyy-MM-dd}'";

            // Gộp với điều kiện hiện có (nếu có)
            string where = string.IsNullOrWhiteSpace(additionalWhereClause)
                ? recentFilter
                : $"{recentFilter} AND ({additionalWhereClause})";

            // Gọi về lớp gốc, dùng paging SQL và count SQL đã có
            return user.GetUserList(page, pageSize, out totalRecords, where);
        }
    }
}
