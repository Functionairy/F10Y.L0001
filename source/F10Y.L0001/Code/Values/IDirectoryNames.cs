using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001
{
    [ValuesMarker]
    public partial interface IDirectoryNames :
        L001.IDirectoryNames
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L001.IDirectoryNames _L001 => L001.DirectoryNames.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
