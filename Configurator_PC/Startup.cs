using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Configurator_PC.Models;   // пространство имен моделей
using Microsoft.EntityFrameworkCore; // пространство имен EntityFramework
using Microsoft.Extensions.Hosting;
using Configurator_PC.Data.EFCore;
using Microsoft.AspNetCore.Identity;

namespace Configurator_PC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            // устанавливаем контекст данных
            services.AddDbContext<AccessoriesContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();
            services.AddControllers(); // используем контроллеры без представлений
            services.AddControllersWithViews();
            services.AddScoped<EfCoreProcessorRepository>();
            services.AddScoped<EfCoreVideoCardRepository>();
            services.AddScoped<EfCoreMotherboardRepository>();
            services.AddScoped<EfCoreCoolingRepository>();
            services.AddScoped<EfCoreRAMRepository>();
            services.AddScoped<EfCoreSSDRepository>();
            services.AddScoped<EfCoreHardDriveRepository>();
            services.AddScoped<EfCorePowerSupplyRepository>();
            services.AddScoped<EfCoreSoundCardRepository>();
            services.AddScoped<EfCoreNetworkAdapterRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();    // подключение аутентификации
            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}