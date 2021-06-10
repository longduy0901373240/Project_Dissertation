using Controller.DM_AD;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Utility;
using Web_App_Medical.Data;

namespace Web_App_Medical
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddDevExpressBlazor();

            services.AddSingleton<CAD_Benh_Vien_Controller>();
            services.AddSingleton<CAD_Khoa_Kham_Controller>();
            services.AddSingleton<CAD_Quan_Controller>();
            services.AddSingleton<CAD_Dia_Chi_Benh_Vien_Controller>();
            services.AddSingleton<CAD_Khoa_Kham_Benh_Vien_Controller>();
            services.AddSingleton<CAD_Dia_Chi_Controller>();

            services.AddHttpContextAccessor();

            services.AddSingleton(CConfig.g_strLuan_Van_Data_Conn_String = Configuration.GetConnectionString("Luan_Van_Data_Conn_String").ToString());
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
