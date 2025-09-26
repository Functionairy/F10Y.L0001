using System;


namespace F10Y.L0001.L000
{
    public class TokenOperator : ITokenOperator
    {
        #region Infrastructure

        public static ITokenOperator Instance { get; } = new TokenOperator();


        private TokenOperator()
        {
        }

        #endregion
    }
}
