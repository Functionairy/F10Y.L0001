using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    /// <summary>
    /// Functions for working with the Files output directory, containing files copied to an output directory.
    /// </summary>
    /// <remarks>
    /// Related prior work: R5T.F0091.
    /// </remarks>
    [FunctionsMarker]
    public partial interface IFilesDirectoryOperator :
        L001.IFilesDirectoryOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L001.IFilesDirectoryOperator _L001 => L001.FilesDirectoryOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
