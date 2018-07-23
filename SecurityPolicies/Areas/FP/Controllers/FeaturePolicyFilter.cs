using System.Web.Mvc;

namespace SecurityPolicies.Areas.FP.Controllers
{
    public class FeaturePolicyFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

            filterContext.HttpContext.Response.Headers.Add("Feature-Policy", "camera 'none'");
        }
    }
}