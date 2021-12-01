using System;
using System.Diagnostics;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0075
{
    [ServiceDefinitionMarker]
    public interface ICommandLineOperator : IServiceDefinition
    {
        Task<int> Run(string command, string arguments, DataReceivedEventHandler receiveOutputData, DataReceivedEventHandler receiveErrorData);
    }
}
