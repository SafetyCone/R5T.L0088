using System;


namespace R5T.L0088.F001
{
    public class ExceptionOperator : IExceptionOperator
    {
        #region Infrastructure

        public static IExceptionOperator Instance { get; } = new ExceptionOperator();


        private ExceptionOperator()
        {
        }

        #endregion
    }
}
