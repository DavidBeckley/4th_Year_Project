﻿using System.Web;
using System.Web.Mvc;

namespace Google_Maps_Transport_Locator
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
