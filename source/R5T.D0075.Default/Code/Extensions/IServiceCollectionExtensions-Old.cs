using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0075.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CommandLineOperator"/> implementation of <see cref="ICommandLineOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddCommandLineOperator_Old(this IServiceCollection services)
        {
            services.AddSingleton<ICommandLineOperator, CommandLineOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CommandLineOperator"/> implementation of <see cref="ICommandLineOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ICommandLineOperator> AddCommandLineOperatorAction_Old(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ICommandLineOperator>(() => services.AddCommandLineOperator_Old());
            return serviceAction;
        }
    }
}
