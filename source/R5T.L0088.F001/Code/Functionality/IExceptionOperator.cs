using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0132;


namespace R5T.L0088.F001
{
    [FunctionalityMarker]
    public partial interface IExceptionOperator : IFunctionalityMarker
    {
        public AssertFailedException Get_AreEqual_AssertFailedException<T>(
            T expected,
            T actual)
        {
            var message = Instances.MessageOperator.Get_AreEqual_FailedMessage(
                expected,
                actual);

            var output = new AssertFailedException(message);
            return output;
        }
    }
}
