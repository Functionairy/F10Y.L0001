using System;

using F10Y.T0003;


namespace F10Y.L0001.L000
{
    /// <summary>
    /// Templates of formats ("{0:0.00}" as opposed to a format, which is "0.00").
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [ValuesMarker]
    public partial interface IFormatTemplates
    {
        /// <inheritdoc cref="IFormats._000"/>
        string _000 => $"{{0:{Instances.Formats._000}}}";

        /// <inheritdoc cref="IFormats._0_00"/>
        string _0_00 => $"{{0:{Instances.Formats._0_00}}}";

        /// <inheritdoc cref="IFormats._0_000"/>
        string _0_000 => $"{{0:{Instances.Formats._0_000}}}";

        /// <inheritdoc cref="L0000.IDateTimeFormats.yyyyMMdd"/>
        string YYYYMMDD => $"{{0:{Instances.DateTimeFormats.yyyyMMdd}}}";

        /// <inheritdoc cref="L0000.IDateTimeFormats.yyyy_MM_dd_Dashed"/>
        string YYYY_MM_DD_Dashed => $"{{0:{Instances.DateTimeFormats.yyyy_MM_dd_Dashed}}}";
    }
}
