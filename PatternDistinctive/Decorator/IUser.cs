﻿using _3S_eShop.BLL.DTOs;
using _3S_eShop.PatternDistinctive.Builder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Decorator
{
    public interface IUser
    {
        DataTable GetUserList(int page, int pageSize, out int totalRecords, string additionalWhereClause = null);
    }
}
