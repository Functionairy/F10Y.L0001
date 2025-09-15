using System;


namespace F10Y.L0001.L000
{
    public class Formats : IFormats
    {
        #region Infrastructure

        public static IFormats Instance { get; } = new Formats();


        private Formats()
        {
        }

        #endregion
    }
}
