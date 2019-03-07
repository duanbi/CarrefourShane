using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrefourShane.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarrefourShane
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 项目运行时将服务添加到容器中
        /// 有关如何配置应用程序的更多信息，请访问：https://go.microsoft.com/fwlink/?LinkID=398940
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //注入
            InitDependency(services);
        }

        /// <summary>
        /// 注入
        /// </summary>
        public void InitDependency(IServiceCollection services)
        {
            //注入 Service 
            services.AddTransient<IProductService, ProductService>();
        }

        /// <summary>
        /// 此方法由运行时调用。使用此方法配置HTTP请求管道。
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="lifetime"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime lifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            // 采用默认路由模式
            app.UseMvcWithDefaultRoute();
            app.UseMvc();
           
        }

    }
}
