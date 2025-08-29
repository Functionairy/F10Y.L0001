using System;

using F10Y.T0003;


namespace F10Y.L0001.L000
{
    [ValuesMarker]
    public partial interface IDateTimeFormatTemplates
    {
        /// <inheritdoc cref="L0000.IDateTimeFormats.yyyyMMdd"/>
        public string yyyyMMdd => $"{{0:{Instances.DateTimeFormats.yyyyMMdd}}}";

        /// <inheritdoc cref="IDateTimeFormats.yyyyMMdd_HHmmss"/>
        public string yyyyMMdd_HHmmss => $"{{0:{Instances.DateTimeFormats.yyyyMMdd_HHmmss}}}";

        /// <inheritdoc cref="IDateTimeFormats.yyyyMMdd_HH_mm_ss_Coloned"/>
        public string yyyyMMdd_HH_mm_ss_Coloned => $"{{0:{Instances.DateTimeFormats.yyyyMMdd_HH_mm_ss_Coloned}}}";

        /// <inheritdoc cref="IDateTimeFormats.yyyyMMdd_HHmmss_Dashed"/>
        public string yyyyMMdd_HHmmss_Dashed => $"{{0:{Instances.DateTimeFormats.yyyyMMdd_HHmmss_Dashed}}}";

        /// <inheritdoc cref="IDateTimeFormats.yyyy_MM_dd_Dashed"/>
        public string yyyy_MM_dd_Dashed => $"{{0:{Instances.DateTimeFormats.yyyy_MM_dd_Dashed}}}";
    }
}
