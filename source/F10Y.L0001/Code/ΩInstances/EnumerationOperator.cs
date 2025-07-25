using System;


namespace F10Y.L0001
{
    public class EnumerationOperator : IEnumerationOperator
    {
        #region Infrastructure

        public static IEnumerationOperator Instance { get; } = new EnumerationOperator();


        private EnumerationOperator()
        {
        }

        #endregion
    }
}
