using HYPJ.Web.Core.Seed;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace HYPJ.MVC.Admin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webhost = BulidWebHost(args);
            StarCloudDbSeed.Init(webhost.Services);
            webhost.Run();
        }

        public static IWebHost BulidWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://*:8021")
            .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true);
                    builder.AddJsonFile($"AppSettings.{context.HostingEnvironment.EnvironmentName}.json", optional: false, reloadOnChange: true);
                })
                .UseStartup<Startup>()
                .Build();
    }
}
