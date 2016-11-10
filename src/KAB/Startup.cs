using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using KAB.Models;
using KAB.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KAB
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connstr = @"Data Source=ACADEMY-6211VF7;Initial Catalog=Project1;Integrated Security=True";


            services.AddDbContext<KABdbcontext>(options => options.UseSqlServer(connstr));
            services.AddMvc();
            AutoMapper.Mapper.Initialize((config) =>
            {
                config.CreateMap<Categories, CategoryVM>();
                config.CreateMap<Product, ProductVM>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
