using System;


namespace R5T.L0088.F001
{
    public class Assertion : IAssertion
    {
        #region Infrastructure

        public static IAssertion Instance { get; } = new Assertion();


        private Assertion()
        {
        }

        #endregion
    }
}
