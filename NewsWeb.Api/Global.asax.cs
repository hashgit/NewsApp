using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Integration.WebApi;
using AutoMapper;
using NewsWeb.ApplicationBuilder;
using NewsWeb.Models;
using IDependencyResolver = System.Web.Http.Dependencies.IDependencyResolver;

namespace NewsWeb.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var container = ContainerManager.BuildContainerWithApi(typeof(WebApiApplication).Assembly);
            // Create the depenedency resolver.
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container) as IDependencyResolver;

            ConfigureMapping();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private void ConfigureMapping()
        {
            Mapper.CreateMap<Category, Dto.Category>();
            Mapper.CreateMap<Article, Dto.CategoryArticleSummary>();
            Mapper.CreateMap<Article, Dto.Article>();
        }
    }
}
