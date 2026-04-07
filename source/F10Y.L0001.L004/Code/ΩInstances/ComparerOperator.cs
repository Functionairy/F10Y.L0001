using System;


namespace F10Y.L0001.L004
{
    public class ComparerOperator : IComparerOperator
    {
        #region Infrastructure

        public static IComparerOperator Instance { get; } = new ComparerOperator();


        private ComparerOperator()
        {
        }

        #endregion
    }
}
