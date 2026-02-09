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


        DateTime Parse_YYYYMMDD_HHMMSS_Dashed(string dateTime)
        {
            var output = this.Parse_Exact(
                dateTime,
                Instances.DateTimeFormats.yyyyMMdd_HHmmss_Dashed);

            return output;
        }

        string To_String_YYYYMMDD(DateTime dateTime)
        {
            var output = $"{dateTime:yyyyMMdd}";
            return output;
        }

        /// <inheritdoc cref="To_String_YYYYMMDD_HHMMSS_Spaced(DateTime)" path="/summary"/>
        /// <para><inheritdoc cref="To_String_YYYYMMDD_HHMMSS_Spaced(DateTime)" path="descendant::example-output"/></para>
        /// <remarks>
        /// Chooses <see cref="To_String_YYYYMMDD_HHMMSS_Spaced(DateTime)"/> as the default.
        /// </remarks>
        string To_String_YYYYMMDD_HHMMSS(DateTime dateTime)
        {
            var output = this.To_String_YYYYMMDD_HHMMSS_Spaced(dateTime);
            return output;
        }

        /// <summary>
		/// Formats the datetime including the year, month, day, hour, minute, and second, with the date and time separated by a space.
        /// <para>
        /// Example output: 
        /// <example-output>
        /// 20221014-151201
        /// </example-output>
        /// </para>
		/// </summary>
        string To_String_YYYYMMDD_HHMMSS_Dashed(DateTime dateTime)
        {
            var formatTemplate = Instances.DateTimeFormatTemplates.yyyyMMdd_HHmmss_Dashed;

            var output = this.Format(
                dateTime,
                formatTemplate);

            return output;
        }

        /// <summary>
		/// Formats the datetime including the year, month, day, hour, minute, and second, with the date and time separated by a space.
        /// <para>
        /// Example output: 
        /// <example-output>
        /// 20221014 151201
        /// </example-output>
        /// </para>
		/// </summary>
        string To_String_YYYYMMDD_HHMMSS_Spaced(DateTime dateTime)
        {
            var formatTemplate = Instances.DateTimeFormatTemplates.yyyyMMdd_HHmmss;

            var output = this.Format(
                dateTime,
                formatTemplate);

            return output;
        }

        string To_String_YYYY_MM_DD(DateTime dateTime)
        {
            var output = $"{dateTime:yyyy-MM-dd}";
            return output;
        }

        /// <inheritdoc cref="To_String_HH_mm_ss_Coloned(DateTime)" path="/summary"/>
        /// <para><inheritdoc cref="To_String_HH_mm_ss_Coloned(DateTime)" path="descendant::example-output"/></para>
        /// <remarks>
        /// Chooses <see cref="To_String_HH_mm_ss_Coloned(DateTime)"/> as the default.
        /// </remarks>
        string To_String_HH_mm_ss(DateTime dateTime)
        {
            var output = this.To_String_HH_mm_ss_Coloned(dateTime);
            return output;
        }

        /// <summary>
        /// Example output: 
        /// <example-output>
        /// 15:12:01
        /// </example-output>
		/// </summary>
        string To_String_HH_mm_ss_Coloned(DateTime dateTime)
        {
            var output = $"{dateTime:HH:mm:ss}";
            return output;
        }
    }
}
