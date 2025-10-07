using System;

using F10Y.T0003;


namespace F10Y.L0001.L000.Raw
{
    [ValuesMarker]
    public partial interface IUnitSymbols
    {
        /// <summary>
        /// <para><value>KB</value></para>
        /// </summary>
        string KB => "KB";

        /// <summary>
        /// <para><value>MB</value></para>
        /// </summary>
        string MB => "MB";

        /// <summary>
        /// <para><value>GB</value></para>
        /// </summary>
        string GB => "GB";

        /// <summary>
        /// <para><value>GiB</value></para>
        /// </summary>
        string GiB => "GiB";
    }
}
