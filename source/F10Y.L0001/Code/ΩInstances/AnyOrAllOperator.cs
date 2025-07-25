using System;


namespace F10Y.L0001
{
    public class AnyOrAllOperator : IAnyOrAllOperator
    {
        #region Infrastructure

        public static IAnyOrAllOperator Instance { get; } = new AnyOrAllOperator();


        private AnyOrAllOperator()
        {
        }

        #endregion
    }
}
