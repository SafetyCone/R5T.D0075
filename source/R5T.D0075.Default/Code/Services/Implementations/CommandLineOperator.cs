using System;
using System.Diagnostics;
using System.Threading.Tasks;

using R5T.T0030;


namespace R5T.D0075
{
    public class CommandLineOperator : ICommandLineOperator
    {
        public Task<int> Run(string command, string arguments, DataReceivedEventHandler receiveOutputData, DataReceivedEventHandler receiveErrorData)
        {
            return CommandLine.Run(command, arguments, receiveOutputData, receiveErrorData);
        }
    }
}
