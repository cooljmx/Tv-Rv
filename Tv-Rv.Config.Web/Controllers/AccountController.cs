using System.Web.Mvc;
using Tv_Rv.Config.Web.Infrastructure.Abstract;
using Tv_Rv.Config.Web.Infrastructure.Concrete;
using Tv_Rv.Config.Web.Models;

namespace Tv_Rv.Config.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthProvider authProvider;
        public AccountController(IAuthProvider authProvider)
        {
            this.authProvider = authProvider;
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }

        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (authProvider.Authenticate(model.UserName, model.Password))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            authProvider.Signout();
            return RedirectToAction("Login", "Account");
        }
    }
}