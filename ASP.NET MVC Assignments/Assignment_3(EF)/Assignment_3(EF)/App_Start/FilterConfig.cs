﻿using System.Web;
using System.Web.Mvc;

namespace Assignment_3_EF_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
