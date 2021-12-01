using System;

using R5T.D0075.T001;


namespace R5T.D0075.X001
{
    public static class Instances
    {
        public static IDataReceivedEventHandler DataReceivedEventHandler { get; } = T001.DataReceivedEventHandler.Instance;
    }
}
