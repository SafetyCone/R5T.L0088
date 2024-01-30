using System;

//using R5T.L0090.T000; // See "Simplified" alias below.
using R5T.T0132;
using R5T.T0239;

using Framework = System.Collections.Generic;
using Simplified = R5T.L0090.T000;


namespace R5T.L0088.F002
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="F001.Documentation.AssertionOperatorNonStandardName" path="/summary"/>
    /// </remarks>
    [FunctionalityMarker]
    public partial interface IAssertion : IFunctionalityMarker,
        F001.IAssertion
    {
        public void Are_Equal<TOutput>(
            IHasOutput<TOutput> expectedValue,
            TOutput encounteredValue,
            Framework.IEqualityComparer<TOutput> equalityComparer)
        {
            this.Are_Equal(
                expectedValue.Output,
                encounteredValue,
                equalityComparer);
        }

        public void Are_Equal<TOutput>(
            IHasOutput<TOutput> expectedValue,
            TOutput encounteredValue)
        {
            this.Are_Equal(
                expectedValue.Output,
                encounteredValue);
        }

        public void Are_Equal<T>(
            T expected,
            T actual,
            Simplified.IEqualityComparer<T> equalityComparer)
        {
            var areEqual = equalityComparer.Equals(expected, actual);
            if(!areEqual)
            {
                throw Instances.ExceptionOperator.Get_AreEqual_AssertFailedException(
                    expected,
                    actual);
            }
        }

        public void Are_Equal<TOutput>(
            IHasOutput<TOutput> expectedValue,
            TOutput encounteredValue,
            Simplified.IEqualityComparer<TOutput> equalityComparer)
        {
            this.Are_Equal(
                expectedValue.Output,
                encounteredValue,
                equalityComparer);
        }
    }
}
