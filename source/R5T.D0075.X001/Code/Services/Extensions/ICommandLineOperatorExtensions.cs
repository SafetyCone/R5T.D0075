using System;
using System.Threading.Tasks;

using R5T.D0075;

using Instances = R5T.D0075.X001.Instances;

namespace System
{
    public static class ICommandLineOperatorExtensions
    {
        public static async Task<int> Run(this ICommandLineOperator commandLineOperator,
            string command, string arguments)
        {
            var exitCode = await commandLineOperator.Run(command, arguments,
                Instances.DataReceivedEventHandler.WriteToConsole(),
                Instances.DataReceivedEventHandler.WriteToConsole());

            return exitCode;
        }
    }
}