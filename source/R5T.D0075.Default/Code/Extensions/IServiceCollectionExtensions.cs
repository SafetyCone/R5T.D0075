using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0075.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CommandLineOperator"/> implementation of <see cref="ICommandLineOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddCommandLineOperator(this IServiceCollection services)
        {
            services.AddSingleton<ICommandLineOperator, CommandLineOperator>();

            return services;
        }
    }
}
