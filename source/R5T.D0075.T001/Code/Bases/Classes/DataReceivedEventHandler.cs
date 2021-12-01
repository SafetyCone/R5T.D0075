using System;


namespace R5T.D0075.T001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class DataReceivedEventHandler : IDataReceivedEventHandler
    {
        #region Static
        
        public static DataReceivedEventHandler Instance { get; } = new();

        #endregion
    }
}