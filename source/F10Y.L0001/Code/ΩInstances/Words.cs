using System;


namespace F10Y.L0001
{
    public class Words : IWords
    {
        #region Infrastructure

        public static IWords Instance { get; } = new Words();


        private Words()
        {
        }

        #endregion
    }
}
