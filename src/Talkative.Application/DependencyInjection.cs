using Microsoft.Extensions.DependencyInjection;
using Talkative.Application.Aella.Services;
using Talkative.Application.Messages.Services;
using Talkative.Application.Talks.Services;

namespace Talkative.Application;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
          
            return services
            .AddServices();
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITalksService,TalksService>();

            services.AddScoped<IMessagesService,MessagesService>();

            services.AddScoped<IAellaService,AellaService>();

            return services;
        }
    }
