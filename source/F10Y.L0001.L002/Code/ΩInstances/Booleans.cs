using System;


namespace F10Y.L0001.L002
{
    public class Booleans : IBooleans
    {
        #region Infrastructure

        public static IBooleans Instance { get; } = new Booleans();


        private Booleans()
        {
        }

        #endregion
    }
}
