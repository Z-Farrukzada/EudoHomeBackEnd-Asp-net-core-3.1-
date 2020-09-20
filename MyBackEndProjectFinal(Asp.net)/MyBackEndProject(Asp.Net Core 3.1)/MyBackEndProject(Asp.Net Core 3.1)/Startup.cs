using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyBackEndProject_Asp.Net_Core_3._1_.DAL;
using MyBackEndProject_Asp.Net_Core_3._1_.Models;

namespace MyBackEndProject_Asp.Net_Core_3._1_
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           


            services.AddIdentity<User, IdentityRole>(Identityoptions => {
                Identityoptions.Password.RequiredLength = 8;
                Identityoptions.Password.RequireLowercase = true;
                Identityoptions.Password.RequireUppercase = true;
                Identityoptions.Password.RequireNonAlphanumeric = true;
                Identityoptions.Password.RequireDigit = true;

                Identityoptions.User.RequireUniqueEmail = true;

                Identityoptions.Lockout.MaxFailedAccessAttempts = 3;
                Identityoptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                Identityoptions.Lockout.AllowedForNewUsers = true;
            
            }).AddEntityFrameworkStores<AppDbcontext>().AddDefaultTokenProviders(); ;

            services.AddDbContext<AppDbcontext>(options => 
            {
                options.UseSqlServer(_config["ConnectionString:Default"]);
            });
           
            services.AddAuthorization();
            services.AddControllersWithViews();
            
           
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=DashBoard}/{action=Index}/{id?}"
                );
               
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
           
        }
    }
}
