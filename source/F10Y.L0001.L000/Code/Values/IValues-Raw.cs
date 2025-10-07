using System;

using F10Y.T0003;


namespace F10Y.L0001.L000.Raw
{
    [ValuesMarker]
    public partial interface IValues
    {
        /// <summary>
        /// <para><value>1,000</value></para>
        /// </summary>
        uint _1_000 => 1_000;

        /// <summary>
        /// <para><value>1,024</value></para>
        /// </summary>
        uint _1_024 => 1024;

        /// <summary>
        /// <para><value>0x04_00 (1,024)</value></para>
        /// </summary>
        uint _1_024_Hex => 0x04_00;

        /// <summary>
        /// <para><value>0b_0100_0000_0000 (1,024)</value></para>
        /// </summary>
        uint _1_024_Binary => 0b_0100_0000_0000;

        /// <summary>
        /// <para><value>1,000,000</value></para>
        /// </summary>
        uint _1_000_000 => 1_000_000;

        /// <summary>
        /// <para><value>1,024 * 1,024</value></para>
        /// </summary>
        uint _1_024_x_1_024 => 1024 * 1024;

        /// <summary>
        /// <para><value>1,000,000,000</value></para>
        /// </summary>
        uint _1_000_000_000 => 1_000_000_000;

        /// <summary>
        /// <para><value>1,024 * 1,024 * 1,024</value></para>
        /// </summary>
        uint _1_024_x_1_024_x_1_024 => 1024 * 1024 * 1024;

        /// <summary>
        /// <para><value>DEFAULT</value></para>
        /// </summary>
        string DEFAULT => "DEFAULT";
    }
}
