using System;


namespace F10Y.L0001.L000
{
    public class IndentationOperator : IIndentationOperator
    {
        #region Infrastructure

        public static IIndentationOperator Instance { get; } = new IndentationOperator();


        private IndentationOperator()
        {
        }

        #endregion
    }
}
