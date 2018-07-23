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

        [ContentSecurityPolicy("style-src 'self' https://maxcdn.bootstrapcdn.com; script-src https://maxcdn.bootstrapcdn.com", false)]
        public ActionResult ScriptSource()
        {
            return View();
        }

        [ContentSecurityPolicy("style-src 'self'", false)]
        public ActionResult StyleSource()
        {
            return View();
        }

        [ContentSecurityPolicy("style-src 'self' https://maxcdn.bootstrapcdn.com; script-src https://maxcdn.bootstrapcdn.com https://code.jquery.com 'self'", false)]
        public ActionResult UnsafeInlineOff()
        {
            return View();
        }

        [ContentSecurityPolicy("style-src 'self' https://maxcdn.bootstrapcdn.com; script-src https://maxcdn.bootstrapcdn.com https://code.jquery.com 'self' 'unsafe-inline';", false)]
        public ActionResult UnsafeInlineOn()
        {
            return View();
        }

        [ContentSecurityPolicy("", false)]
        public ActionResult CSPwithSRI()
        {
            return View();
        }
    }
}