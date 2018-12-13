using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrashService.BLL.Contracts;
using CrashService.BLL.Services;
using CrashService.DAL.Contracts.Context;
using CrashService.DAL.Contracts.Repositories;
using CrashService.DAL.Data.Repositories;
using CrashService.DAL.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CrashService.WebAPI
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
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IDetectorService, DetectorService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IDbContext, CrashServiceDbContext>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IDetectorRepository, DetectorRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
