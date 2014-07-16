namespace Tv_Rv.Config.Web.Infrastructure.Abstract
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
        void Signout();
    }
}
