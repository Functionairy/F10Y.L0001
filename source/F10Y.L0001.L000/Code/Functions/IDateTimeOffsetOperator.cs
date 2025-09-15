using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IDateTimeOffsetOperator :
        L0000.IDateTimeOffsetOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IDateTimeOffsetOperator _L0000 => L0000.DateTimeOffsetOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <inheritdoc cref="IDateTimeFormatTemplates.dd_MMM_yyyy_HH_Colon_mm"/>
        public string To_DD_MMM_YYYY_HH_Colon_MM(DateTimeOffset dateTimeOffset)
        {
            var output = this.Format(
                dateTimeOffset,
                Instances.DateTimeFormatTemplates.dd_MMM_yyyy_HH_Colon_mm);

            return output;
        }
    }
}
