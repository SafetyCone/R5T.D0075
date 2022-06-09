using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0075.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CommandLineOperator"/> implementation of <see cref="ICommandLineOperator"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ICommandLineOperator> AddCommandLineOperatorAction(this IServiceAction _)
        {
            var serviceAction = _.New<ICommandLineOperator>(services => services.AddCommandLineOperator());
            return serviceAction;
        }
    }
}
