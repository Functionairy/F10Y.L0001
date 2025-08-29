using System;

using F10Y.T0003;


namespace F10Y.L0001.L000
{
    /// <summary>
    /// XML node names for the .NET documentation file.
    /// </summary>
    [ValuesMarker]
    public partial interface IDocumentationXmlNodeNames
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>assembly</value></para>
        /// </summary>
        public string assembly => "assembly";

        /// <summary>
        /// <para><value>doc</value></para>
        /// </summary>
        public string doc => "doc";

        /// <summary>
        /// <para><value>members</value></para>
        /// </summary>
        public string members => "members";

        /// <summary>
        /// <para><value>name</value></para>
        /// </summary>
        public string name => "name";

#pragma warning restore IDE1006 // Naming Styles
    }
}
