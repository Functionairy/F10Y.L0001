using System;


namespace F10Y.L0001.X000
{
    public static class Instances
    {
        public static L0000.IArrayOperator ArrayOperator => L0000.ArrayOperator.Instance;
        public static L0000.ICollectionOperator CollectionOperator => L0000.CollectionOperator.Instance;
        public static L0000.IDictionaryOperator DictionaryOperator => L0000.DictionaryOperator.Instance;
        public static L000.IEnumerableOperator EnumerableOperator => L000.EnumerableOperator.Instance;
        public static L0000.IFileSystemInfoOperator FileSystemInfoOperator => L0000.FileSystemInfoOperator.Instance;
        public static L0000.IHashSetOperator HashSetOperator => L0000.HashSetOperator.Instance;
        public static L0000.IListOperator ListOperator => L0000.ListOperator.Instance;
        public static L0000.IOrderOperator OrderOperator => L0000.OrderOperator.Instance;
        public static L000.IStringOperator StringOperator => L000.StringOperator.Instance;
        public static L0000.IStrings Strings => L0000.Strings.Instance;
        public static L0000.ITextOperator TextOperator => L0000.TextOperator.Instance;
    }
}