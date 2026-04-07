using System;

using F10Y.T0003;


namespace F10Y.L0001.L000
{
    [ValuesMarker]
    public partial interface ITexts
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>null</value></para>
        /// </summary>
        string @null => "null";

        /// <summary>
        /// <para><value>&lt;null&gt;</value></para>
        /// </summary>
        string null_Bracketed => "<null>";

        /// <summary>
        /// <para><value>Press any key to close...</value></para>
        /// </summary>
        public string PressAnyKeyToClose => "Press any key to close...";

#pragma warning restore IDE1006 // Naming Styles
    }
}
