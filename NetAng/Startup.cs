using NetAng.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using System;
using Microsoft.AspNetCore.Identity;

namespace NetAng
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
            ////Pomelo.EntityFrameworkCore.MySql      -v: >5
            //services.AddDbContextPool<AuthDbContext>(
            //    dbContextOptions => dbContextOptions
            //        .UseMySql(
            //            // Replace with your connection string.
            //            Configuration.GetConnectionString("PomeloConnection"),
            //            // Replace with your server version and type.
            //            // For common usages, see pull request #1233.
            //            new MySqlServerVersion(new Version(10, 4, 14))
            //           , 
            ////            // use MariaDbServerVersion for MariaDB
            //            mySqlOptions => mySqlOptions
            //                .CharSetBehavior(CharSetBehavior.NeverAppend))
            ////// Everything from this point on is optional but helps with debugging.
            //.EnableSensitiveDataLogging()
            //.EnableDetailedErrors()
            //);

            services.AddDbContext<AuthDbContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("PostgresConnection")));

            //services.AddDbContext<AuthDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("AuthConnectionSqLite")));

            //Pomelo.EntityFrameworkCore.MySql      -v: <5
            //services.AddDbContext<AuthDbContext>(options => options
            //    .UseMySql(Configuration.GetConnectionString("PomeloConnection"),
            //        mysqlOptions =>
            //            mysqlOptions.ServerVersion(new ServerVersion(new Version(10, 4, 14), ServerType.MariaDb))
            //            ));

            //MySql.Data.EntityFrameworkCore Version: < 5
            //services.AddDbContext<AuthDbContext>(options => options
            //    .UseMySQL(Configuration.GetConnectionString("MySqlConnection")
            //));

            //Devart.Data.MySql.EFCore      have Licence!
            //services.AddDbContext<AuthDbContext>(options => options.UseMySql
            //    (Configuration.GetConnectionString("MySqlConnection")
            //));



            services.AddDefaultIdentity<ApplicationUser>().AddEntityFrameworkStores<AuthDbContext>();
            //services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AuthDbContext>().AddDefaultTokenProviders().;

            services.AddIdentityServer().AddApiAuthorization<ApplicationUser, AuthDbContext>();
            services.AddAuthentication().AddIdentityServerJwt();

            services.AddControllers();
            services.AddRazorPages();
            //services.AddControllersWithViews();

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
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
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseIdentityServer();

            app.UseEndpoints(endpoints =>
            { 
                endpoints.MapControllers();//?????????????????????????????
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");//"{controller}/{action}"

                //endpoints.MapControllerRoute(
                //    name: "public",
                //    pattern: "{public}/{action}");

                endpoints.MapRazorPages();
               
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    //spa.UseAngularCliServer(npmScript: "start");//for start spa  with core project
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
                }
            });
        }
    }
}
