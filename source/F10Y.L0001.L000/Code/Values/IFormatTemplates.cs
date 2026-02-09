using System;

using F10Y.T0003;


namespace F10Y.L0001.L000
{
    [ValuesMarker]
    public partial interface IFormatTemplates
    {
        /// <inheritdoc cref="IFormats._0_00"/>
        string _0_00 => $"{{0:{Instances.Formats._0_00}}}";

        /// <inheritdoc cref="IFormats._0_000"/>
        string _0_000 => $"{{0:{Instances.Formats._0_000}}}";

        /// <inheritdoc cref="L0000.IDateTimeFormats.yyyyMMdd"/>
        string YYYYMMDD => $"{{0:{Instances.DateTimeFormats.yyyyMMdd}}}";
    }
}
