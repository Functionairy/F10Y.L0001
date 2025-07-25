using System;


namespace F10Y.L0001
{
    public class ContiguityOperator : IContiguityOperator
    {
        #region Infrastructure

        public static IContiguityOperator Instance { get; } = new ContiguityOperator();


        private ContiguityOperator()
        {
        }

        #endregion
    }
}
