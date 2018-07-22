using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityPolicies.Areas.CSP.Controllers
{
    public class CSPController : Controller
    {
        // GET: CSP/CSP
        public ActionResult Index()
        {
            return View();
        }
    }
}