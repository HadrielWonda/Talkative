using Microsoft.Extensions.DependencyInjection;

using Talkative.Application.Talks.Services;

namespace Talkative.Application;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ITalksService,TalksService>();

            return services;
        }
    }
