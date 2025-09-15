using System;
using System.Collections.Generic;
using System.IO;

using Instances = F10Y.L0001.X000.Instances;


namespace System.Linq
{
    public static class FileSystemInfoExtensions
    {
        /// <inheritdoc cref="F10Y.L0000.IFileSystemInfoOperator.Order_ByWriteTime_Descending{T}(IEnumerable{T})"/>
        public static IEnumerable<T> Order_ByWriteTime_Descending<T>(this IEnumerable<T> fileSystemInfos)
            where T : FileSystemInfo
            => Instances.FileSystemInfoOperator.Order_ByWriteTime_Descending(fileSystemInfos);
    }
}
