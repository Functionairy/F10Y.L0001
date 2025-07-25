using System;


namespace F10Y.L0001
{
    public class RandomOperator : IRandomOperator
    {
        #region Infrastructure

        public static IRandomOperator Instance { get; } = new RandomOperator();


        private RandomOperator()
        {
        }

        #endregion
    }
}
