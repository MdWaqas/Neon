using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Neon.FinanceBridge.Application.CommandHandlers;
using Neon.FinanceBridge.Data.SQL.Repositories;
using Neon.FinanceBridge.Data.SQL.Repositories.Impl;
using Neon.FinanceBridge.Infrastructure;
using Neon.FinanceBridge.Tracing;
using System.Diagnostics;
using System.Reflection;
using AutoMapper;
using FluentValidation;
using Neon.FinanceBridge.API.Configurations;
using Neon.FinanceBridge.Application.AutoMapper;
using Neon.FinanceBridge.Application.Commands.Customer;
using Neon.FinanceBridge.Application.Validations.Customer;
using Neon.FinanceBridge.Domain.Services;
using Neon.FinanceBridge.Infrastructure.Configurations;
using Neon.FinanceBridge.Infrastructure.Identity;
using Neon.FinanceBridge.Infrastructure.Services;
using Neon.FinanceBridge.Application.Commands.Item;
using Neon.FinanceBridge.Application.Validations.Item;
using System.Data;
using Microsoft.Data.SqlClient;
using Neon.FinanceBridge.Infrastructure.Queries.Item;
using Neon.FinanceBridge.Application.Queries.Item;
using Neon.FinanceBridge.Infrastructure.Queries;
using Neon.FinanceBridge.Application.Queries;

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
            services.AddAutoMapper(typeof(CommandToModelMappingProfile));
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerSetup();
            services.AddCustomTracing(Configuration, DiagnosticSourceName).AddValidators();

            services.Configure<AppSettings>(Configuration.GetSection(nameof(AppSettings)));
            services.AddMediatR(typeof(AddCustomerCommand).Assembly);
            services.AddMediatR(typeof(UpdateCustomerCommand).Assembly);
            services.AddMediatR(typeof(DeleteCustomerCommand).Assembly);
            services.AddMediatR(typeof(AuthenticateUserCommandHandler).Assembly);
            
            services.AddDbContext<FinanceBridgeDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddTransient<IDbConnection>((sp) => new SqlConnection(Configuration["ConnectionStrings:DefaultConnection"]));

            services.AddIdentitySetup(Configuration);

            services.AddScoped<ICrudRepository, CrudRepository<FinanceBridgeDbContext>>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IItemQueries, ItemQueries>();
            services.AddScoped<IBaseQuery, BaseQuery>();

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
            app.UseSwaggerSetup();

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
            services.AddSingleton<IValidator<AddCustomerCommand>, AddCustomerValidations>();
            services.AddSingleton<IValidator<UpdateCustomerCommand>, UpdateCustomerValidations>();
            services.AddSingleton<IValidator<DeleteCustomerCommand>, DeleteCustomerValidations>();

            services.AddSingleton<IValidator<AddItemCommand>, AddItemValidations>();
            services.AddSingleton<IValidator<UpdateItemCommand>, UpdateItemValidations>();
            services.AddSingleton<IValidator<DeleteItemCommand>, DeleteItemValidations>();

            return services;
        }
    }
}
