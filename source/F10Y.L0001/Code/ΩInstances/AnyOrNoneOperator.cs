using System;


namespace F10Y.L0001
{
    public class AnyOrNoneOperator : IAnyOrNoneOperator
    {
        #region Infrastructure

        public static IAnyOrNoneOperator Instance { get; } = new AnyOrNoneOperator();


        private AnyOrNoneOperator()
        {
        }

        #endregion
    }
}
