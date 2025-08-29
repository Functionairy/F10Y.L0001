using System;


namespace F10Y.L0001.L000
{
    public class DateTimeFormatTemplates : IDateTimeFormatTemplates
    {
        #region Infrastructure

        public static IDateTimeFormatTemplates Instance { get; } = new DateTimeFormatTemplates();


        private DateTimeFormatTemplates()
        {
        }

        #endregion
    }
}
