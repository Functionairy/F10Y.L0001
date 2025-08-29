using System;


namespace F10Y.L0001.L000
{
    public class Strings : IStrings
    {
        #region Infrastructure

        public static IStrings Instance { get; } = new Strings();


        private Strings()
        {
        }

        #endregion
    }
}
