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
using Microsoft.EntityFrameworkCore;
using MVCSamples.Data;
using Microsoft.AspNetCore.Http;

using MVCSamples.Middleware;

namespace MVCSamples
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
            

            services.AddControllersWithViews();//3.1 

            services.AddDbContext<MovieDBContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MovieDBContext")));

            services.AddHealthChecks();

            services.AddSession();
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

            AppDomain.CurrentDomain.SetData("BildVerzeichnis", env.WebRootPath);


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseSession();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("Products", "Products/{action=Index}/{id?}", new { controller = "Products" });
            //    routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
            //});

            app.UseAuthorization();



            app.MapWhen(context => context.Request.Path.ToString().Contains("imagegen"), subapp =>
            {
                subapp.UseThumbnailGen();
            });



            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapHealthChecks("/healthz").RequireAuthorization();

                //endpoints.MapGet("/hello/{name:alpha}", async context =>
                //{
                //    var name = context.Request.RouteValues["name"];
                //    await context.Response.WriteAsync($"Hello {name}!");
                //});

                //https://localhost:44331/Blog/ShowBlogs?Day=15&Month=7&Year=2020
                //endpoints.MapControllerRoute(
                //    name: "Blog",
                //    pattern: "Blog/{action=ShowBlogs}/{Day}/{Month}/{Year}");


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
