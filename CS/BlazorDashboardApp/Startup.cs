using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;

namespace BlazorDashboardApp {
    public class Startup {
        public Startup(IConfiguration configuration, IWebHostEnvironment hostingEnvironment) {
            Configuration = configuration;
            FileProvider = hostingEnvironment.ContentRootFileProvider;
        }

        public IConfiguration Configuration { get; }
        public IFileProvider FileProvider { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddMvc();
            services.AddScoped((IServiceProvider serviceProvider) => {
                DashboardConfigurator configurator = new DashboardConfigurator();

                // Register Dashboard Storage
                configurator.SetDashboardStorage(new DashboardFileStorage(FileProvider.GetFileInfo("App_Data/Dashboards").PhysicalPath));

                // Create a sample data source
                DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
                DashboardObjectDataSource objectDataSource = new DashboardObjectDataSource("Object Data Source") { DataId = "employees" };
                configurator.DataLoading += (s, e) => {
                    if(e.DataId == "employees") {
                        e.Data = Employee.Employees;
                    }
                };

                dataSourceStorage.RegisterDataSource("objectDataSource", objectDataSource.SaveToXml());
                configurator.SetDataSourceStorage(dataSourceStorage);

                return configurator;
            });
            services.AddSingleton<IDashboardLocalizationProvider, DashboardLocalizationProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            var supportedCultures = new[] { "en-US", "de-DE" };
            var supportedUICultures = new[] { "en-US", "de-DE" };
            var localizationOptions = new RequestLocalizationOptions()
                .SetDefaultCulture(supportedCultures[1])
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedUICultures);

            app.UseRequestLocalization(localizationOptions);

            app.UseEndpoints(endpoints => {
                EndpointRouteBuilderExtension.MapDashboardRoute(endpoints, "api/dashboard", "DefaultDashboard");
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
