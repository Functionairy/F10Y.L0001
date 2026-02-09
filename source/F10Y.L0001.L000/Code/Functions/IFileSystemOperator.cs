using System;
using System.IO;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IFileSystemOperator :
        L0000.IFileSystemOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IFileSystemOperator _F10Y_L0000 => L0000.FileSystemOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Returns the latest last modified time of all files in a directory.
        /// </summary>
        /// <remarks>
        /// Recursive.
        /// <para>
        /// Function is not in L0000 due to awkwardness of function name.
        /// </para>
        /// </remarks>
        DateTime Get_LastModifiedTime_ForFilesInDirectory(
            string directoryPath)
        {
            var directory = Instances.DirectoryInfoOperator.From(directoryPath);

            var output = Instances.DirectoryInfoOperator.Get_LastModifiedTime_ForFilesInDirectory(directory);
            return output;
        }

        DateTime Get_LastModifiedTime_ForFiles(
            string directoryPath,
            Func<string, bool> descendantDirectoryRecursionPredicate)
        {
            var directoryInfo = Instances.DirectoryInfoOperator.From(directoryPath);

            bool DescendantDirectoryRecursionPredicate_Actual(DirectoryInfo directoryInfo)
            {
                var directoryPath = Instances.DirectoryInfoOperator.Get_DirectoryPath(directoryInfo);

                var output = descendantDirectoryRecursionPredicate(directoryPath);
                return output;
            }

            var output = Instances.DirectoryInfoOperator.Get_LastModifiedTime_ForFiles(
                directoryInfo,
                DescendantDirectoryRecursionPredicate_Actual);

            return output;
        }
    }
}
