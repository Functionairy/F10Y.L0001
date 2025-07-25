using System;


namespace F10Y.L0001.L002
{
    public class ResultOperator : IResultOperator
    {
        #region Infrastructure

        public static IResultOperator Instance { get; } = new ResultOperator();


        private ResultOperator()
        {
        }

        #endregion
    }


    public class ResultOperator<TInput, TOutput> : IResultOperator<TInput, TOutput>
    {
        #region Infrastructure

        public static IResultOperator<TInput, TOutput> Instance { get; } = new ResultOperator<TInput, TOutput>();


        private ResultOperator()
        {
        }

        #endregion
    }
}
