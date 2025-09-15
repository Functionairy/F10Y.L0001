using System;


namespace F10Y.L0001.L000
{
    public class TimingOperator : ITimingOperator
    {
        #region Infrastructure

        public static ITimingOperator Instance { get; } = new TimingOperator();


        private TimingOperator()
        {
        }

        #endregion
    }
}
