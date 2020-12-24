using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.DependencyInjection;

using GroupDotnetAPI.Data;

namespace GroupDotnetAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
               
                try
                {
                    var context = services.GetRequiredService<GroupContext>();
                    /** 
                    #region Eager
                    using (var context = services.GetRequiredService<GroupContext>())
                    {
                   var group = context.Groups
                    .Single(g => g.GroupID == 1);

                   context.Entry(group)
                    .Collection(g => g.Members)
                    .Load();
                     //DbInitializer.Initialize(context);
                    }
                    #endregion
                   **/
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
           
            host.Run();

            //CreateHostBuilder(args).Build().Run();
        }

       //https://github.com/dotnet/EntityFramework.Docs/blob/master/samples/core/Querying/RelatedData/Program.cs
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
