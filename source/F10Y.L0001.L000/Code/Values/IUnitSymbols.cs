using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [ValuesMarker]
    public partial interface IUnitSymbols
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        Raw.IUnitSymbols _Raw => Raw.UnitSymbols.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// 1024 * 1024 * 1024 (2^30)
        /// <inheritdoc cref="Raw.IUnitSymbols.GiB" path="descendant::value[1]"/>
        /// </summary>
        string Gibibyte => _Raw.GiB;

        /// <summary>
        /// <inheritdoc cref="Raw.IUnitSymbols.GB" path="descendant::value[1]"/>
        /// </summary>
        string Gigabyte => _Raw.GB;
    }
}
