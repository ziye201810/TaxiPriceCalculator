using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TaxiPriceCalculator
{
    static class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine($"Hello Taxi Price Calculator! Your cost would be: {new TaxiPriceCalculator().Cost(0)}");
            CreateWebHostBuilder(args).Build().Run();
        }

        static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        }
    }
}