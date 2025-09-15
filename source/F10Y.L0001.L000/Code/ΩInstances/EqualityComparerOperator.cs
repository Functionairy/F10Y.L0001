using System;


namespace F10Y.L0001.L000
{
    public class EqualityComparerOperator : IEqualityComparerOperator
    {
        #region Infrastructure

        public static IEqualityComparerOperator Instance { get; } = new EqualityComparerOperator();


        private EqualityComparerOperator()
        {
        }

        #endregion
    }
}
