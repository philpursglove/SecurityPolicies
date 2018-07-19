using System.Web.Mvc;

namespace SecurityPolicies.Areas.SRI
{
    public class SRIAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SRI";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SRI_default",
                "SRI/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}