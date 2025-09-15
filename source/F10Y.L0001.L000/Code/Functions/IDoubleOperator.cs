using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IDoubleOperator :
        L0000.IDoubleOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IDoubleOperator _L0000 => L0000.DoubleOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="L0000.IDoubleOperator.To_String_WithThreeDecimalPlaces(double)"/>
        /// <remarks>
        /// Uses the <see cref="IFormatTemplates._0_000"/> format template.
        /// </remarks>
        public new string To_String_WithThreeDecimalPlaces(double value)
        {
            var output = Instances.StringOperator.Format_WithTemplate(
                Instances.FormatTemplates._0_000,
                value);

            return output;
        }
    }
}
