using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HPCCLibrary
{
    public class Startup
    {
        private const string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LibraryDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

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


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IGenreRepository, GenreRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IGroupeRepository, GroupeRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IStudentBookRepository, StudentBookRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<ITeacherRepository, TeacherRepository>();
            services.AddTransient<ITeacherBookRepository, TeacherBookRepository>();
            services.AddTransient<ILibraryService, LibraryService>();
            services.AddDbContext<LibraryContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("DataAccessLayer")));
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
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
