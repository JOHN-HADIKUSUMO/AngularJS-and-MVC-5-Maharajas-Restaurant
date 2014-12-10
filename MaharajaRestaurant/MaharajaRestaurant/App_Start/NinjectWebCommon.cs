using System;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using System.Web.Http;
using Ninject.Web.Common;
using MaharajaRestaurant.Ninject;
using MaharajaRestaurant.DAL;
using MaharajaRestaurant.DAL.Services;
using MaharajaRestaurant.DAL.Interfaces;
using MaharajaRestaurant.Business;
using MaharajaRestaurant.Business.Interfaces;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MaharajaRestaurant.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MaharajaRestaurant.NinjectWebCommon), "Stop")]

namespace MaharajaRestaurant
{
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kernel);
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }


        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ILibrary>().To<Library>();
            kernel.Bind<IMenusService>().To<MenusService>();
            kernel.Bind<IPhotoMenusService>().To<PhotoMenusService>();
            kernel.Bind<IMenusLibrary>().To<MenusLibrary>();
            kernel.Bind<IPhotoMenusLibrary>().To<PhotoMenusLibrary>();
            kernel.Bind<IMaharajasDBContext>().To<MaharajaRestaurant.DAL.MaharajasDbContext>();
            

        }        
    }
}
