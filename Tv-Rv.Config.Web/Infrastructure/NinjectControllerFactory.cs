using System.Web.Mvc;
using Ninject;
using Tv_Rv.Config.Web.Infrastructure.Abstract;
using Tv_Rv.Config.Web.Infrastructure.Concrete;

namespace Tv_Rv.Config.Web.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, System.Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}