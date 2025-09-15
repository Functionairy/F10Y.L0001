using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [ValuesMarker]
    public partial interface IDateTimeFormats :
        L0000.IDateTimeFormats
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IDateTimeFormats _L0000 => L0000.DateTimeFormats.Instance;

#pragma warning restore IDE1006 // Naming Styles


#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// 20 Mar 2025 14:49
        /// <para><value>dd MMM yyyy HH:mm</value></para>
        /// </summary>
        public string dd_MMM_yyyy_HH_Colon_mm => "dd MMM yyyy HH:mm";

        /// <summary>
        /// <para><value>yyyyMMdd HHmmss</value></para>
        /// </summary>
        public string yyyyMMdd_HHmmss => "yyyyMMdd HHmmss";

        /// <summary>
        /// <para><value>yyyyMMdd-HH:mm:ss</value></para>
        /// </summary>
        public string yyyyMMdd_HH_mm_ss_Coloned => "yyyyMMdd-HH:mm:ss";

        /// <summary>
        /// <para><value>yyyyMMdd-HHmmss</value></para>
        /// </summary>
        public string yyyyMMdd_HHmmss_Dashed => "yyyyMMdd-HHmmss";

        /// <summary>
        /// <para><value>yyyy-MM-dd</value></para>
        /// <para><description>YYYY-MM-DD</description></para>
        /// </summary>
        public string yyyy_MM_dd_Dashed => "yyyy-MM-dd";

#pragma warning restore IDE1006 // Naming Styles
    }
}
