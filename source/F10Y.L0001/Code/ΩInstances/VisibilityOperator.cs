using System;


namespace F10Y.L0001
{
    public class VisibilityOperator : IVisibilityOperator
    {
        #region Infrastructure

        public static IVisibilityOperator Instance { get; } = new VisibilityOperator();


        private VisibilityOperator()
        {
        }

        #endregion
    }
}
