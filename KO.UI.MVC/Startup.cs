using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KO.BLL.Interfaces;
using KO.BLL.Services;
using KO.DAL;
using KO.DAL.Interfaces;
using KO.DAL.Repositories;
using KO.UI.MVC.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KO.UI.MVC
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddDbContext<KO_DBContext>(options => options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IExamsOfMemberRepository, ExamsOfMemberRepository>();
            services.AddScoped<IExamsOfMemberService, ExamsOfMemberService>();
            services.AddScoped<IQuestionOfExamService, QuestionOfExamService>();
            services.AddScoped<IQuestionOfExamRepository, QuestionOfExamRepository>();
            services.AddScoped<IOptionsOfQuestionRepository, OptionsOfQuestionRepository>();
            services.AddScoped<IOptionsOfQuestionService, OptionsOfQuestionService>();
            services.AddScoped<MemberFilterAttribute>();
            services.AddTransient<KO_Initializer>(); //for seed
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, KO_Initializer Seeder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseSession();
            app.UseMvcWithDefaultRoute(); app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Login}/{action=Index}/{id?}");

            }
            );

            Seeder.Seed().Wait();//for seed
        }
    }
}
