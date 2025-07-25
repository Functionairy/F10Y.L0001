using System;


namespace F10Y.L0001
{
    public class EnumerableOperator : IEnumerableOperator
    {
        #region Infrastructure

        public static IEnumerableOperator Instance { get; } = new EnumerableOperator();


        private EnumerableOperator()
        {
        }

        #endregion
    }
}
