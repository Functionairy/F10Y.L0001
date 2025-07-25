using System;

using F10Y.T0003;


namespace F10Y.L0001.L003.Raw
{
    [ValuesMarker]
    public partial interface ITextRepresentations
    {
        /// <summary>
        /// <para><value>&lt;empty&gt;</value></para>
        /// </summary>
        public string N_001 => "<empty>";

        /// <summary>
        /// <para><value>&lt;carriage-return&gt;</value></para>
        /// </summary>
        public string N_002 => "<carriage-return>";

        /// <summary>
        /// <para><value>&lt;newline&gt;</value></para>
        /// </summary>
        public string N_003 => "<newline>";

        /// <summary>
        /// <para><value>&lt;null&gt;</value></para>
        /// </summary>
        public string N_004 => "<null>";

        /// <summary>
        /// <para><value>&lt;space&gt;</value></para>
        /// </summary>
        public string N_005 => "<space>";

        /// <summary>
        /// <para><value>&lt;tab&gt;</value></para>
        /// </summary>
        public string N_006 => "<tab>";

        /// <summary>
        /// <para><value>&lt;unknown&gt;</value></para>
        /// </summary>
        public string N_007 => "<unknown>";

        /// <summary>
        /// <para><value>\r</value></para>
        /// </summary>
        public string N_008 => @"\r";

        /// <summary>
        /// <para><value>\n</value></para>
        /// </summary>
        public string N_009 => @"\n";

        /// <summary>
        /// <para><value>\s</value></para>
        /// </summary>
        public string N_010 => @"\s";

        /// <summary>
        /// <para><value>\t</value></para>
        /// </summary>
        public string N_011 => @"\t";

        /// <summary>
        /// <para><value>&lt;none&gt;</value></para>
        /// </summary>
        public string N_012 => "<none>";
    }
}
