using System.Web.Mvc;

namespace SecurityPolicies.Areas.FP
{
    public class FPAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "FP";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "FP_default",
                "FP/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}