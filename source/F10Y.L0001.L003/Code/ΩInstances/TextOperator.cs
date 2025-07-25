using System;


namespace F10Y.L0001.L003
{
    public class TextOperator : ITextOperator
    {
        #region Infrastructure

        public static ITextOperator Instance { get; } = new TextOperator();


        private TextOperator()
        {
        }

        #endregion
    }
}
