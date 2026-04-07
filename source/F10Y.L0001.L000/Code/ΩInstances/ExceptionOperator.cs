using System;


namespace F10Y.L0001.L000
{
    public class ExceptionOperator : IExceptionOperator
    {
        #region Infrastructure

        public static IExceptionOperator Instance { get; } = new ExceptionOperator();


        private ExceptionOperator()
        {
        }

        #endregion
    }
}
