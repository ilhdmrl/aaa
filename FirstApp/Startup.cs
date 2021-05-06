using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FirstApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            var marketimConStr=Configuration.GetConnectionString("MarketimConnection");
            //var logLevel = Configuration.GetSection("LogType")
            //    .GetChildren()
            //    .AsEnumerable()
            //    .Single(c=>c.Key=="Level")
            //    .Value;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllersWithViews(opt =>
            //{
            //    opt.EnableEndpointRouting = false;
            //});

            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseMvc(route =>
            //{
            //    route.MapRoute(
            //        name:"default",
            //        template:"{controller}/{action}/{id?}",
            //        defaults: new {controller="Home",action="Index"}
            //    );
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                                
            });


        }
    }
}
