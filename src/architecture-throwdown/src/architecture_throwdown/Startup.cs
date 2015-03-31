using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.DependencyInjection;
    
namespace architecture_throwdown
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
			app.UseMvc(routes => {
				routes.MapRoute(
					name:"default", 
					template: "{controller}/{action}/{id?}", 
					defaults:new { controller = "Home", action = "Index" }
				);
			});
            
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
