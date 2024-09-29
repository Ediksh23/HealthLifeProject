using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using HealthLifeProject.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace HealthLifeProject
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
            //отримуємо рядок підключення з конфігураційного файлу
            string connection = Configuration.GetConnectionString("DefaultConnection");
            //додаємо контекст ApplicationContext як сервіс у додаток
            services.AddDbContext<HealthLifeDBContext>(options =>
                options.UseSqlServer(connection));

            services.AddControllersWithViews();

            services.AddTransient<BenefactorsRepository>();
            services.AddTransient<CategoryRepository>();
            services.AddTransient<TreatmentCategoryRepository>();
            services.AddTransient<CitiesRepository>();
            services.AddTransient<HospitalsCharitableContributionsRepository>();
            services.AddTransient<ContactPhonesRepository>();
            services.AddTransient<DiagnosesRepository>();
            services.AddTransient<EntrancesRepository>();
            services.AddTransient<FundraisingStatusesRepository>();
            services.AddTransient<HospitalsRepository>();
            services.AddTransient<HospitalsRepresentativesRepository>();
            services.AddTransient<HospitalsCharitableContributionsRepository>();
            services.AddTransient<HousesRepository>();
            services.AddTransient<NamesRepository>();
            services.AddTransient<PatientsRepository>();
            services.AddTransient<PatientsCharitableContributionsRepository>();
            services.AddTransient<PartnersRepresentativesRepository>();
            services.AddTransient<PatronymicsRepository>();
            services.AddTransient<PositionsRepository>();
            services.AddTransient<PartnersRepository>();
            services.AddTransient<RolesRepository>();
            services.AddTransient<GenderRepository>();
            services.AddTransient<StreetsRepository>();
            services.AddTransient<StreetTypesRepository>();
            services.AddTransient<SurnamesRepository>();
            services.AddTransient<WardsRepository>();



            services.AddHttpContextAccessor();
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

            app.Use(async (context, next) => {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/Error/PageNotFound";
                    await next();
                }
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            // Виклик функціі SeedData
           /* using (var scope = app.ApplicationServices.CreateScope())
            {
                // HealthLifeDBContext content = scope.ServiceProvider.GetRequiredService<HealthLifeDBContext>();
                var services = scope.ServiceProvider;
                SeedData.Initialize(services);
            }*/
        }
    }
}
