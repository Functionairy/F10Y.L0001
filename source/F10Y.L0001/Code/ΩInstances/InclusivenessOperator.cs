using System;


namespace F10Y.L0001
{
    public class InclusivenessOperator : IInclusivenessOperator
    {
        #region Infrastructure

        public static IInclusivenessOperator Instance { get; } = new InclusivenessOperator();


        private InclusivenessOperator()
        {
        }

        #endregion
    }
}
