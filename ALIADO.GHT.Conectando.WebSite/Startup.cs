using ALIADO.GHT.Conectando.WebSite.Models;
using ALIADO.GHT.Conectando.WebSite.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace ALIADO.GHT.Conectando.WebSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddHttpClient();
            services.AddControllers();

            services.AddTransient<JsonFileLiveService>();
            services.AddTransient<JsonFileVideoService>();
            services.AddTransient<MediaAPIService>();
            
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options =>
               {
                   options.LoginPath = "/login";
                   options.AccessDeniedPath = "/denied";

                    //To check what is going on 
                    options.Events = new CookieAuthenticationEvents()
                   {
                       OnSigningIn = async context =>
                       {
                           var principal = context.Principal;
                           if (principal.HasClaim(c => c.Type == ClaimTypes.NameIdentifier))
                           {
                                // this user comes from database or someplace
                                if (principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value == "j")
                               {
                                   var claimsIdentity = principal.Identity as ClaimsIdentity;
                                   claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));
                               }
                           }

                           await Task.CompletedTask;
                       },
                       OnSignedIn = async context =>
                       {
                           await Task.CompletedTask;
                       },
                       OnValidatePrincipal = async context =>
                       {
                           await Task.CompletedTask;

                       }
                   };
               });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
            });           
        }
    }
}
