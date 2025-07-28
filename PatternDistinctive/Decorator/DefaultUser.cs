using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.Builder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Decorator
{
    public class DefaultUser : IUser
    {
         public DataTable GetUserList(
        int page,
        int pageSize,
        out int totalRecords,
        string additionalWhereClause = null
    )
    {
       
        var countBuilder = new PagingQueryBuilder("Users", "id")
                                .SetSelectCount(true);
        if (!string.IsNullOrWhiteSpace(additionalWhereClause))
            countBuilder.AddSpecific(additionalWhereClause);

        string countSql = countBuilder.Build(); 
 

        totalRecords = Convert.ToInt32(
            DataProvider.Instance.ExecuteScalar(countSql)
        );

      
        var dataBuilder = new PagingQueryBuilder("Users", "id")
                               .SetPage(page)
                               .SetPageSize(pageSize)
                               .SetSelect("*");
        if (!string.IsNullOrWhiteSpace(additionalWhereClause))
            dataBuilder.AddSpecific(additionalWhereClause);

        string dataSql = dataBuilder.Build();
        return DataProvider.Instance.ExecuteQuery(dataSql);
    }
    }
}
