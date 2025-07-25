using System;


namespace F10Y.L0001
{
    public class SwitchOperator : ISwitchOperator
    {
        #region Infrastructure

        public static ISwitchOperator Instance { get; } = new SwitchOperator();


        private SwitchOperator()
        {
        }

        #endregion
    }
}
