using System;


namespace F10Y.L0001.L000
{
    public class OnceOperator : IOnceOperator
    {
        #region Infrastructure

        public static IOnceOperator Instance { get; } = new OnceOperator();


        private OnceOperator()
        {
        }

        #endregion
    }
}
