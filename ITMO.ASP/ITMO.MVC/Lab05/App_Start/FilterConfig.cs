﻿using System.Web;
using System.Web.Mvc;

namespace ITMO.MVC2023.Task05
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
