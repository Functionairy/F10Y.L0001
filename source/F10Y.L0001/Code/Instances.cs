using System;


namespace F10Y.L0001
{
    public static class Instances
    {
        public static L0000.IDirectoryNameOperator DirectoryNameOperator => L0000.DirectoryNameOperator.Instance;
        public static IDirectoryNames DirectoryNames => L0001.DirectoryNames.Instance;
        public static L0000.IExecutablePathOperator ExecutablePathOperator => L0000.ExecutablePathOperator.Instance;
        public static L0000.IPathOperator PathOperator => L0000.PathOperator.Instance;
    }
}