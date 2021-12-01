using System;


namespace R5T.D0075.T001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class DataReceivedEventHandlerOperator : IDataReceivedEventHandlerOperator
    {
        #region Static
        
        public static DataReceivedEventHandlerOperator Instance { get; } = new();

        #endregion
    }
}