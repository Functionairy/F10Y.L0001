using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IDateTimeOperator :
        L0000.IDateTimeOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IDateTimeOperator _L0000 => L0000.DateTimeOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Chooses <see cref="To_String_YYYYMMDD_HHMMSS_Space(DateTime)"/> as the default.
        /// <para><inheritdoc cref="To_String_YYYYMMDD_HHMMSS_Space(DateTime)" path="/summary"/></para>
        /// </summary>
        public string To_String_YYYYMMDD_HHMMSS(DateTime dateTime)
        {
            var output = this.To_String_YYYYMMDD_HHMMSS_Space(dateTime);
            return output;
        }

        /// <summary>
		/// Example output: 20221014 151201
		/// </summary>
        public string To_String_YYYYMMDD_HHMMSS_Space(DateTime dateTime)
        {
            var formatTemplate = Instances.DateTimeFormatTemplates.yyyyMMdd_HHmmss;

            var output = this.Format(
                dateTime,
                formatTemplate);

            return output;
        }

        public string To_String_YYYY_MM_DD(DateTime dateTime)
        {
            var output = $"{dateTime:yyyy-MM-dd}";
            return output;
        }
    }
}
