using System;


namespace F10Y.L0001
{
    public class OrderDependenceOperator : IOrderDependenceOperator
    {
        #region Infrastructure

        public static IOrderDependenceOperator Instance { get; } = new OrderDependenceOperator();


        private OrderDependenceOperator()
        {
        }

        #endregion
    }
}
