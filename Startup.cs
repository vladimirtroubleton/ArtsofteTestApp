using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtsofteTestApp.ModelBuilders;
using ArtsofteTestApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ArtsofteTestApp
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

            string connection = Configuration.GetConnectionString("DbConnectionString");
            services.AddDbContext<AppContext>(options =>
                options.UseSqlServer(connection));

            services.AddScoped<IDepartamentRepository, DepartamentRepository>();
            services.AddScoped<IProgrammingLanguageDataRepository, ProgrammingLanguageDataRepository>();
            services.AddScoped<IStaffModelBuilder, StaffModelBuilder>();
            services.AddScoped<IStaffDataRepository, StaffDataRepository>();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
