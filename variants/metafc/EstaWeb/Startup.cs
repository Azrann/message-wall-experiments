using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstaWebSeAutodestruira;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;

namespace EstaWeb
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
            services.AddControllersWithViews();
            services.AddSingleton<MessageService>();
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
            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = ctx =>
                {
                    const int durationInSeconds = 60 * 60 * 24;
                    ctx.Context.Response.Headers[HeaderNames.CacheControl] =
                        "max-age=" + durationInSeconds;
                }
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "like",
                    pattern: "like/{id}",
                    defaults: new { controller = "Home", action = "Like" }); ;
                endpoints.MapControllerRoute(
                    name: "DeleteMensaje",
                    pattern: "DeleteMensaje/{id}/{key}",
                    defaults: new { controller = "Home", action = "DeleteMensaje" });
                endpoints.MapControllerRoute(
                    name: "mensajesbyId",
                    pattern: "mensajes/{id}",
                    defaults: new { controller = "Home", action = "MensajeById" });
                endpoints.MapControllerRoute(
                    name: "mensajes",
                    pattern: "mensajes",
                    defaults: new { controller = "Home", action = "Mensaje" });
                endpoints.MapControllerRoute(
                    name: "ttl",
                    pattern: "ttl",
                    defaults: new { controller = "Home", action = "Ttl" });
                endpoints.MapControllerRoute(
                    name: "Undostrespericoingles",
                    pattern: "Undostrespericoingles",
                    defaults: new { controller = "Home", action = "Undostrespericoingles" });
                endpoints.MapControllerRoute(
                    name: "VerTodosLosMensajes",
                    pattern: "a",
                    defaults: new { controller = "Home", action = "VerTodosLosMensajesAdmin" });
                endpoints.MapControllerRoute(
                    name: "IndexById",
                    pattern: "mensaje/{id}",
                    defaults: new { controller = "Home", action = "IndexById" });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
