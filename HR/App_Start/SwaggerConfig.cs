using System.Web.Http;
using WebActivatorEx;
using Web_Application;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Web_Application
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Web_Application");
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}
