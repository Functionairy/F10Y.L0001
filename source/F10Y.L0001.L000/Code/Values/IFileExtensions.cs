using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [ValuesMarker]
    public partial interface IFileExtensions :
        L0000.IFileExtensions
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IFileExtensions _L0000 => L0000.FileExtensions.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>txt</value></para>
        /// </summary>
        public string Text => "txt";
    }
}
