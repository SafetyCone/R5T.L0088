using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0132;


namespace R5T.L0088.F001
{
    [FunctionalityMarker]
    public partial interface IMessageOperator : IFunctionalityMarker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Message format discovered using R5T.S0111.V000.Tests.AreEqual_ForIntegers().
        /// </remarks>
        public string Get_AreEqual_FailedMessage(
            object expected,
            object actual)
        {
            var output = $"{nameof(Assert)}.{nameof(Assert.AreEqual)} failed. Expected:<{expected}>. Actual:<{actual}>.";
            return output;
        }
    }
}
