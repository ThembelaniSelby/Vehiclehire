using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Vehiclehire.Models;

namespace Vehiclehire
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AuthenticateRequest()
        {

            //check if user is logged in
            if (User == null) { return; }

            //get username
            string Email = Context.User.Identity.Name;
            //declare array of roles
            string[] roles = null;

            using (Db db = new Db())
            {
                User dto = db.Users.FirstOrDefault(x => x.EmailAddress == Email);
                roles = db.UserRoles.Where(x => x.UserId == dto.Id).Select(x => x.Role.Name).ToArray();
            }

            //build IPrincipal object
            IIdentity userIdentity = new GenericIdentity(Email);
            IPrincipal newUserObj = new GenericPrincipal(userIdentity, roles);
            //update context.user
            Context.User = newUserObj;
        }
    }
}
