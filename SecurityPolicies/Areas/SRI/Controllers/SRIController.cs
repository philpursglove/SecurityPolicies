using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityPolicies.Areas.SRI.Controllers
{
    public class SRIController : Controller
    {
        // GET: SRI/SRI
        public ActionResult WorkingLink()
        {
            return View();
        }

        public ActionResult BrokenLink()
        {
            return View();
        }

        public ActionResult BrokenLinkWithFallback()
        {
            return View();
        }
    }
}