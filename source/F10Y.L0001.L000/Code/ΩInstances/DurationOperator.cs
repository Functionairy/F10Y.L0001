using System;


namespace F10Y.L0001.L000
{
    public class DurationOperator : IDurationOperator
    {
        #region Infrastructure

        public static IDurationOperator Instance { get; } = new DurationOperator();


        private DurationOperator()
        {
        }

        #endregion
    }
}
