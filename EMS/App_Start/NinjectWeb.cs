
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject.Web;
using Ninject.Web.Common.WebHost;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(EMS.App_Start.NinjectWeb), "Start")]

namespace EMS.App_Start
{
    public static class NinjectWeb
    {
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
        }
    }
}