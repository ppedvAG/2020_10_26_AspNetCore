﻿using System.Web;
using System.Web.Mvc;

namespace AspNet_SinglePages_Overview
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
