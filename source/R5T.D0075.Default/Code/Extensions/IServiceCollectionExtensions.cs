using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.E0024.D001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CommandLineOperator"/> implementation of <see cref="ICommandLineOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddCommandLineOperator(this IServiceCollection services)
        {
            services.AddSingleton<ICommandLineOperator, CommandLineOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CommandLineOperator"/> implementation of <see cref="ICommandLineOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ICommandLineOperator> AddCommandLineOperatorAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ICommandLineOperator>(() => services.AddCommandLineOperator());
            return serviceAction;
        }
    }
}
