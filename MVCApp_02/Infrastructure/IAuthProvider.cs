using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp_02.Infrastructure
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password, bool rememberMe); 
    }
}