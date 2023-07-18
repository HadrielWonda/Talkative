using Microsoft.Extensions.DependencyInjection;
using Talkative.Application.Talks.Interfaces;
using Talkative.Infrastructure.Persistence;

namespace Talkative.Infrastructure;

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ITalksRepository,TalksRepository>();

            return services;
        }
    }
