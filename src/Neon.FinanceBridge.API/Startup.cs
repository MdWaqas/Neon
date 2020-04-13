using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Neon.FinanceBridge.Application.CommandHandlers;
using Neon.FinanceBridge.Application.Commands;

using Neon.FinanceBridge.Data.SQL.Repositories;
using Neon.FinanceBridge.Data.SQL.Repositories.Impl;
using Neon.FinanceBridge.Domain.Repositories;
using Neon.FinanceBridge.Infrastructure;
using Neon.FinanceBridge.Infrastructure.Repositories;
using Neon.FinanceBridge.Tracing;
using System.Diagnostics;
using System.Reflection;
using AutoMapper;
using Neon.FinanceBridge.Domain.Services;
using Neon.FinanceBridge.Infrastructure.Configurations;
using Neon.FinanceBridge.Infrastructure.Services;

namespace Neon.FinanceBridge.API
{
    public class Startup
    {
        private static readonly string DiagnosticSourceName = Assembly.GetEntryAssembly().GetName().Name;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Neon API",
                    Description = "Finanace Bridge",
                    Contact = new OpenApiContact
                    {
                        Name = "Waqas Idrees",
                        Email = string.Empty
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX"
                    }
                });
            });
            services.AddCustomTracing(Configuration, DiagnosticSourceName).AddValidators();

            services.Configure<AppSettings>(Configuration.GetSection(nameof(AppSettings)));

            //services.AddMediatR(typeof(InsertUserCommandHandler).Assembly);
            services.AddMediatR(typeof(AuthenticateUserCommandHandler).Assembly);
            
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            
            services.AddScoped<ICrudRepository, CrudRepository<ApplicationDbContext>>();
            services.AddScoped<IUserRepository, UserRepository>();
            
            services.AddScoped<IUserService, UserService>();
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            
        }
    }

    static class CustomExtensionsMethods
    {
        public static IServiceCollection AddCustomTracing(this IServiceCollection services, IConfiguration configuration, string diagnosticSourceName)
        {
            services.AddSingleton(provider => new DiagnosticListener(diagnosticSourceName));
            services.AddSingleton(typeof(IDiagnosticSpanBuilder<>), typeof(DiagnosticSpanBuilder<>));
            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            //services.AddSingleton<IValidator<InsertUserCommand>, InsertUserCommandValidator>();
            return services;
        }
    }
}
