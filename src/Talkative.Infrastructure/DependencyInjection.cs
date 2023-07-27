using Microsoft.Extensions.DependencyInjection;

using Talkative.Application.Messages.Interfaces;
using Talkative.Application.Talks.Interfaces;
using Talkative.Infrastructure.Persistence;
using Talkative.Infrastructure.Services;
using Talkative.Domain.Common.Interfaces;

namespace Talkative.Infrastructure;

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services
              .AddPersistence()
              .AddServices();
                
        }


          private static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddScoped<ITalksRepository,TalksRepository>();

            services.AddScoped<IMessagesRepository,MessagesRepository>();

            return services;
        }

          private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDateTimeProvider,DateTimeProvider>();

            return services;
        }
    }
