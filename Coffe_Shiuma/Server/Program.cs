using Coffe_Shiuma.Server.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace Coffe_Shiuma.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Host = CreateHostBuilder(args).Build();
            var ScopeFactory = Host.Services.GetRequiredService<IServiceScopeFactory>();
            using (var Scope = ScopeFactory.CreateScope())
            {
                var Context = Scope.ServiceProvider
                .GetRequiredService<CafeteriaStoreContext>();
                if (!Context.Specials.Any())
                {
                    SeedData.Initialize(Context);
                }
            }
            Host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
