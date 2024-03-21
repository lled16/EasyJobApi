using EasyJob.Application.Interfaces;
using EasyJob.Application.Mappings;
using EasyJob.Application.Services;
using EasyJob.Domain.Interfaces;
using EasyJob.Infra.Data.Context;
using EasyJob.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyJob.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddAutoMapper(typeof(DomainToDTOMapping));

            services.AddScoped<IAnuncioServices, AnuncioServices>();
            services.AddScoped<IAnunciosRepository, AnunciosRepository>();


            return services;
        }
    }
}
