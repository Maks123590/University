namespace Task8
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using Task8.Models;
    using Task8.Models.Extensions;
    using Task8.Models.Web.Enums;

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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            TariffExtensionMethods.DriverPrice = int.Parse(this.Configuration.GetSection("ServicesPrices:Driver").Value);
            TariffExtensionMethods.DriverPrice = int.Parse(this.Configuration.GetSection("ServicesPrices:Gps").Value);

            services.AddTransient<PriceSettings>(p => new PriceSettings
                                                          {
                                                              PriceItems = new List<PriceItem>
                                                                               {
                                                                                   new PriceItem
                                                                                       {
                                                                                           TariffType = TariffType.Base,
                                                                                           PriceKm = int.Parse(this.Configuration.GetSection("TariffPrices:Base:Km").Value),
                                                                                           PriceMin = int.Parse(this.Configuration.GetSection("TariffPrices:Base:Min").Value)
                                                                                       },
                                                                                   new PriceItem
                                                                                       {
                                                                                           TariffType = TariffType.PerHours,
                                                                                           PriceKm = int.Parse(this.Configuration.GetSection("TariffPrices:PerHours:Km").Value),
                                                                                           PriceMin = int.Parse(this.Configuration.GetSection("TariffPrices:PerHours:Min").Value)
                                                                                       },
                                                                                   new PriceItem
                                                                                       {
                                                                                           TariffType = TariffType.Daily,
                                                                                           PriceKm = int.Parse(this.Configuration.GetSection("TariffPrices:Daily:Km").Value),
                                                                                           PriceMin = int.Parse(this.Configuration.GetSection("TariffPrices:Daily:Min").Value)
                                                                                       },
                                                                                   new PriceItem
                                                                                       {
                                                                                           TariffType = TariffType.Student,
                                                                                           PriceKm = int.Parse(this.Configuration.GetSection("TariffPrices:Student:Km").Value),
                                                                                           PriceMin = int.Parse(this.Configuration.GetSection("TariffPrices:Student:Min").Value)
                                                                                       },
                                                                               }
                                                          });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/CarSharing/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.Use(async (context, next) =>
                {
                    try
                    {
                        await next.Invoke();
                    }
                    catch (Exception e)
                    {
                        await context.Response.WriteAsync(e.Message);
                    }
                    
                });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=CarSharing}/{action=Index}/{id?}");
            });
        }
    }
}
