using Entities.Mapping;
using Entities.Models.Main;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Repository;
using Repository.Repository;
using Services.Dent;
using Services.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dent.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddMainRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<Partner>), typeof(MainRepository<Partner>));
            return services;
        }

        public static IServiceCollection AddPartnerRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(PartnerRepository<>));
            return services;
        }

        public static IServiceCollection AddMainServices(this IServiceCollection services)
        {
            services.AddScoped<IPartnerService, PartnerService>();
            return services;
        }

        public static IServiceCollection AddPartnerServices(this IServiceCollection services)
        {
            services.AddScoped<IArtService, ArtService>();
            return services;
        }

        public static IServiceCollection AddMappingProfiles(this IServiceCollection services)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DentMappingProfile());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            //services.AddAutoMapper(typeof(DentMappingProfile));
            return services;
        }
    }
}
