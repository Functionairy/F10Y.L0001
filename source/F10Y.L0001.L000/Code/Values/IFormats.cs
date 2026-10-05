using System;

using F10Y.T0003;


namespace F10Y.L0001.L000
{
    /// <summary>
    /// Formats (like "0.00").
    /// <para>
    /// See also: <see cref="IFormatTemplates"/> (like "{0:0.00}")
    /// </para>
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [ValuesMarker]
    public partial interface IFormats
    {
        /// <summary>
        /// <para><value>000</value></para>
        /// </summary>
        string _000 => "000";

        /// <summary>
        /// <para><value>0.00</value></para>
        /// </summary>
        string _0_00 => "0.00";

        /// <summary>
        /// <para><value>0.000</value></para>
        /// </summary>
        string _0_000 => "0.000";
    }
}
