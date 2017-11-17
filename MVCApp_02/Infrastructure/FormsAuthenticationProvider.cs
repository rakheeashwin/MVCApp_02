using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MVCApp_02.Infrastructure
{
    public class FormsAuthenticationProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password, bool rememberMe)
        {
            bool status = false;
            if (username == "text" && password == "pwd")
                status = true;

            if(status)
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);
            }
            return status;
        }
    }
}