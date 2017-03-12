using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Reflection;
using My.BusinessLayer;
using My.DataAccess;
using My.Repository;

namespace My.WebClient
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            IocConfig.Configure();

             
        }


        public class  IocConfig
        {
            public static void Configure()
            {
                var builder = new ContainerBuilder();
                 builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
                // builder.RegisterType<DbFirstEntities1>().AsImplementedInterfaces().InstancePerLifetimeScope();
                builder.RegisterType<DbFirstEntities1>().InstancePerDependency();
                builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
                builder.RegisterType<CustomerIdentifyStrategy>().As<ICustomerIdentifyStrategy>();
                builder.RegisterType<My.BusinessLayer.TestClass>().As<My.BusinessLayer.ITestClass>();
                var config = GlobalConfiguration.Configuration;
                var container = builder.Build();
                config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            }
            
        }
    }
}
