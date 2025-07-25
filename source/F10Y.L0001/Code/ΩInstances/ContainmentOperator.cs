using System;


namespace F10Y.L0001
{
    public class ContainmentOperator : IContainmentOperator
    {
        #region Infrastructure

        public static IContainmentOperator Instance { get; } = new ContainmentOperator();


        private ContainmentOperator()
        {
        }

        #endregion
    }
}
