using System;
using System.Diagnostics;
using System.Threading.Tasks;


namespace R5T.D0075
{
    public interface ICommandLineOperator
    {
        Task<int> Run(string command, string arguments, DataReceivedEventHandler receiveOutputData, DataReceivedEventHandler receiveErrorData);
    }
}
