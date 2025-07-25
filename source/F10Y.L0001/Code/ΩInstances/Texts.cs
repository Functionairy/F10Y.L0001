using System;


namespace F10Y.L0001
{
    public class Texts : ITexts
    {
        #region Infrastructure

        public static ITexts Instance { get; } = new Texts();


        private Texts()
        {
        }

        #endregion
    }
}
