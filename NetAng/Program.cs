using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });



        //public static IHostBuilder CreateHostBuilder(string[] args) => 
        //    Host.CreateDefaultBuilder(args).
        //    ConfigureServices(
        //    (hostContext, services) =>
        //    {
        //        services.AddHostedService<Worker>();

        //        // Set the active provider via configuration
        //        var configuration = hostContext.Configuration;
        //        var provider = configuration.GetValue("Provider", "SqlServer");

        //        services.AddDbContext<BlogContext>(
        //            options => _ = provider switch
        //            {
        //                "Sqlite" => options.UseSqlite(
        //                    configuration.GetConnectionString("SqliteConnection"),
        //                    x => x.MigrationsAssembly("SqliteMigrations")),

        //                "SqlServer" => options.UseSqlServer(
        //                    configuration.GetConnectionString("SqlServerConnection"),
        //                    x => x.MigrationsAssembly("SqlServerMigrations")),

        //                _ => throw new Exception($"Unsupported provider: {provider}")
        //            });
        //    });




    }
}
