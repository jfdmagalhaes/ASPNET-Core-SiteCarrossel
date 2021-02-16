using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CasaDoCodigo
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var livros = new List<Livr>();
            livros.Add(new Livr("001", "Quem mexeu na query?", 12.22m));
            livros.Add(new Livr("002", "Quem mexeu no meu código?", 15.22m));
            livros.Add(new Livr("003", "Quem mexeu no meu repositório?", 20.22m));

            app.Run(async (context) =>
            {
                foreach (var livro in livros)
                {
                    await context.Response.WriteAsync($"{livro.Codigo,-10}{livro.Nome, -40}{livro.Preco.ToString("C"),10}\r\n");
                }
                
            });
        }
    }
}
