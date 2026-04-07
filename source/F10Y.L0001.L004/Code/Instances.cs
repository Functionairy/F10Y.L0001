using System;


namespace F10Y.L0001.L004
{
    public static class Instances
    {
        public static L0000.IComparisonResults ComparisonResults => L0000.ComparisonResults.Instance;
        public static L0000.IDictionaryOperator DictionaryOperator => L0000.DictionaryOperator.Instance;
        public static L0000.IEqualityComparers EqualityComparers => L0000.EqualityComparers.Instance;
        public static L0000.IExceptionOperator ExceptionOperator => L0000.ExceptionOperator.Instance;
        public static L0000.IHashSetOperator HashSetOperator => L0000.HashSetOperator.Instance;
        public static Z000.ISeeds Seeds => Z000.Seeds.Instance;
        public static ITypeSpecifierOperator TypeSpecifierOperator => L004.TypeSpecifierOperator.Instance;
    }
}