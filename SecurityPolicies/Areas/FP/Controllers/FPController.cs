﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityPolicies.Areas.FP.Controllers
{
    public class FPController : Controller
    {
        // GET: FP/FP
        public ActionResult UseBrowserFeatures()
        {
            return View();
        }

        [FeaturePolicyFilter]
        public ActionResult BlockedBrowserFeatures()
        {
            return View();
        }
    }
}