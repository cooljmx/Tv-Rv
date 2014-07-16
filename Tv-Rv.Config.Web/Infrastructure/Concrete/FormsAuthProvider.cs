using System.Web.Security;
using Tv_Rv.Config.Web.Infrastructure.Abstract;

namespace Tv_Rv.Config.Web.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            var result = FormsAuthentication.Authenticate(username, password);
            if (result)
                FormsAuthentication.SetAuthCookie(username,false);
            return result;
        }

        public void Signout()
        {
            FormsAuthentication.SignOut();
        }
    }
}