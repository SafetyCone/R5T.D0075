using System;
using System.Diagnostics;

using IDataReceivedEventHandler = R5T.D0075.T001.IDataReceivedEventHandler;


namespace System
{
    public static class IDataReceivedEventHandlerExtensions
    {
        public static DataReceivedEventHandler WriteToConsole(this IDataReceivedEventHandler _)
        {
            static void Output(object sender, DataReceivedEventArgs eventArgs)
            {
                Console.WriteLine(eventArgs.Data);
            }

            return Output;
        }
    }
}