using System;
using System.Diagnostics;
using System.Threading.Tasks;

using R5T.T0030;
using R5T.T0064;


namespace R5T.D0075
{
    [ServiceImplementationMarker]
    public class CommandLineOperator : ICommandLineOperator, IServiceImplementation
    {
        public async Task<int> Run(string command, string arguments, DataReceivedEventHandler receiveOutputData, DataReceivedEventHandler receiveErrorData)
        {
            var exitCode = await CommandLine.Run(command, arguments, receiveOutputData, receiveErrorData);
            return exitCode;
        }
    }
}
