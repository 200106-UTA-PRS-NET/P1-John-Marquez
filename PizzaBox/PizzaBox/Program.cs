using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pizza_Data.Models;

namespace PizzaBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             DbContextOptions<Entity> options;
             var configurBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = configurBuilder.Build();
            var optionsBuilder = new DbContextOptionsBuilder<Entity>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("PizzaDb"));
            options = optionsBuilder.Options;

            */



            CreateHostBuilder(args).Build().Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
