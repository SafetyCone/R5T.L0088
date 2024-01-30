using System;


namespace R5T.L0088.F001
{
    public class MessageOperator : IMessageOperator
    {
        #region Infrastructure

        public static IMessageOperator Instance { get; } = new MessageOperator();


        private MessageOperator()
        {
        }

        #endregion
    }
}
