using System.Web.Mvc;

namespace SecurityPolicies.Areas.CSP.Controllers
{
    public class CSPController : Controller
    {
        [ContentSecurityPolicy("", true)]
        public ActionResult ReportOnly()
        {
            return View();
        }
    }
}