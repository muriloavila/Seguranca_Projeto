using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebApplication4;
using WebMatrix.WebData;

namespace WebApplication4
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("SegurancaConnectionString", "tabUsuario", "Id", "Nome", autoCreateTables: true);
            }

            if (!Roles.RoleExists("administrador"))
            {
                Roles.CreateRole("administrador");
            }
            if (!WebSecurity.UserExists("administrador"))
            {
                WebSecurity.CreateUserAndAccount("administrador", "123456", new {Email = "administrador@administrador.com"});
                Roles.AddUserToRole("administrador", "administrador");
            }
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
