using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SaturnoManagementAPI.Configuração;
using Microsoft.EntityFrameworkCore;
using SaturnoManagementAPI.Interfaces;
using SaturnoManagementAPI.Tabelas;
using SaturnoManagementAPI.Model;

namespace SaturnoManagementAPI
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
            services.AddDbContext<ERPContext>(options =>
       options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // services.AddDbContext<ERPContext>(opt => opt.UseInMemoryDatabase("Database"));
            services.AddScoped<ERPContext, ERPContext>();
            services.AddScoped<ICliente, ClienteModel>();
            services.AddScoped<IProduto, ProdutoModel>();
            services.AddScoped<IUsuario, UsuarioModel>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
