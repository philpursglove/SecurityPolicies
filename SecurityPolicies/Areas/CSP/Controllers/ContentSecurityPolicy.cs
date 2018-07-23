using System.Web.Mvc;

namespace SecurityPolicies.Areas.CSP.Controllers
{
    public class ContentSecurityPolicy : ActionFilterAttribute
    {
        private readonly string Policy;
        private readonly bool ReportOnly;

        public ContentSecurityPolicy(string policy, bool reportOnly)
        {
            Policy = policy;
            ReportOnly = reportOnly;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

            if (ReportOnly)
            {
                filterContext.HttpContext.Response.Headers.Add("Content-Security-Policy-Report-Only", Policy);
            }
            else
            {
                filterContext.HttpContext.Response.Headers.Add("Content-Security-Policy", Policy);
            }
        }
    }
}