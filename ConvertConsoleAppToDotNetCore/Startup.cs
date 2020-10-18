using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertConsoleAppToDotNetCore
{
    public class Startup
    {

        public void ConfigurationServices(IServiceCollection service)
        {

        }


        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapGet("/", async conext =>
                {
                  await  conext.Response.WriteAsync("Hello from Application");
                });
            });

        }
    }
}
