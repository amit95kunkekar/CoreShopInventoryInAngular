﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace CoreShopInventoryInAngular.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CoreShopInventoryInAngularControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}