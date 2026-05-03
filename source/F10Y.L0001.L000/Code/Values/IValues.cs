using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [ValuesMarker]
    public partial interface IValues :
        L0000.IValues
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        Raw.IValues _Raw => Raw.Values.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_000" path="descendant::value[1]"/>
        /// </summary>
        uint Kilo => _Raw._1_000;

        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_000_000" path="descendant::value[1]"/>
        /// </summary>
        uint Mega => _Raw._1_000_000;

        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_000_000_000" path="descendant::value[1]"/>
        /// </summary>
        uint Giga => _Raw._1_000_000_000;

        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_024" path="descendant::value[1]"/>
        /// </summary>
        int Kibi => _Raw._1_024;

        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_024_AsInt32" path="descendant::value[1]"/>
        /// </summary>
        int Kibi_AsInt32 => _Raw._1_024_AsInt32;

        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_024_AsUInt32" path="descendant::value[1]"/>
        /// </summary>
        uint Kibi_AsUInt32 => _Raw._1_024_AsUInt32;

        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_024_x_1_024" path="descendant::value[1]"/>
        /// </summary>
        int Mebi => _Raw._1_024_x_1_024;

        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_024_x_1_024" path="descendant::value[1]"/>
        /// </summary>
        int Mebi_AsInt32 => _Raw._1_024_x_1_024_AsInt32;

        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_024_x_1_024" path="descendant::value[1]"/>
        /// </summary>
        uint Mebi_AsUInt32 => _Raw._1_024_x_1_024_AsUnit32;

        /// <summary>
        /// <inheritdoc cref="Raw.IValues._1_024_x_1_024_x_1_024" path="descendant::value[1]"/>
        /// </summary>
        uint Gibi => _Raw._1_024_x_1_024_x_1_024;
    }
}
