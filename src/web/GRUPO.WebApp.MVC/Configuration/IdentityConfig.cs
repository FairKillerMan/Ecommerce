using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GRUPO.WebApp.MVC.Configuration
{
    public static class IdentityConfig
    {
        public static void AddIdentityConfiguration(this IServiceCollection services) //Método de extensão: IServiceCollection ()
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) //Add autenticação do tipo cookie usando o schema
                .AddCookie(options =>
                {
                    options.LoginPath = "/login";           //Caminho para fazer login
                    options.AccessDeniedPath = "/erro/403"; //Sem acesso
                });
        }

        public static void UseIdentityConfiguration(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}