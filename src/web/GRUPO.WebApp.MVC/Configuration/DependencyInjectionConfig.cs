using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using GRUPO.WebApp.MVC.Extensions;
using GRUPO.WebApp.MVC.Services;

namespace GRUPO.WebApp.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}