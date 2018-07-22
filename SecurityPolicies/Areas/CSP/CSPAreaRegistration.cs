using System.Web.Mvc;

namespace SecurityPolicies.Areas.CSP
{
    public class CSPAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CSP";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CSP_default",
                "CSP/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}