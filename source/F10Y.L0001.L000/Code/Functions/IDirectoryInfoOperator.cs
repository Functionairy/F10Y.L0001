using System;
using System.IO;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IDirectoryInfoOperator :
        L0000.IDirectoryInfoOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IDirectoryInfoOperator _L0000 => L0000.DirectoryInfoOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        DateTime Get_LastModifiedTime_ForFiles_UTC(
            DirectoryInfo directoryInfo,
            Func<DirectoryInfo, bool> descendantDirectoryRecursionPredicate)
            => this.Get_LastModifiedFile(
                directoryInfo,
                descendantDirectoryRecursionPredicate)
                // Return the UTC time.
                .LastWriteTimeUtc;

        /// <summary>
        /// Chooses <see cref="Get_LastModifiedTime_ForFilesInDirectory_Local(DirectoryInfo)"/> as the default.
        /// </summary>
        DateTime Get_LastModifiedTime_ForFilesInDirectory(DirectoryInfo directoryInfo)
            => this.Get_LastModifiedTime_ForFilesInDirectory_Local(directoryInfo);

        DateTime Get_LastModifiedTime_ForFilesInDirectory_Local(DirectoryInfo directoryInfo)
            => this.Get_LastModifiedTime_ForFiles_Local(
                directoryInfo,
                Instances.FunctionOperator.Return_True);

        DateTime Get_LastModifiedTime_ForFilesInDirectory_UTC(DirectoryInfo directoryInfo)
            => this.Get_LastModifiedTime_ForFiles_UTC(
                directoryInfo,
                Instances.FunctionOperator.Return_True);
    }
}
