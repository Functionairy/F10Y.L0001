using System;

using F10Y.T0003;


namespace F10Y.L0001.L000
{
    [ValuesMarker]
    public partial interface IFormats
    {
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
