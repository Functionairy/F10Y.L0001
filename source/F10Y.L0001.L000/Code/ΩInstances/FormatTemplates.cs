using System;


namespace F10Y.L0001.L000
{
    public class FormatTemplates : IFormatTemplates
    {
        #region Infrastructure

        public static IFormatTemplates Instance { get; } = new FormatTemplates();


        private FormatTemplates()
        {
        }

        #endregion
    }
}
