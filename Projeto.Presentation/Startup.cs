using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projeto.Application.Mappings;
using Swashbuckle.AspNetCore.Swagger;

namespace Projeto.Presentation
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
            AutoMapperConfig.Register();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //configuração para gerar a documentação do Swagger
            //configurando o Swagger
            services.AddSwaggerGen(
                swagger =>
                {
                    swagger.SwaggerDoc("v1",
                        new Info
                        {
                            Title = "Controle de Turma - D'Amico School",
                            Description = "Projeto para controle de turma",
                            Version = "v1",
                            Contact = new Contact
                            {
                                Name = "D'Amico School",
                                Email = "lucas21_pereira@hotmail.com",
                                Url = "http://www.cotiinformatica.com.br"
                            }
                        });
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger(); //ativando o swagger
            app.UseSwaggerUI(s => { s.SwaggerEndpoint("/swagger/v1/swagger.json", "Aula"); });
        }
    }
}
