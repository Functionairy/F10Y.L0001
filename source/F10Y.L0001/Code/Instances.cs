using System;


namespace F10Y.L0001
{
    public static class Instances
    {
        public static L0000.ICharacters Characters => L0000.Characters.Instance;
        public static L0000.IDirectoryNameOperator DirectoryNameOperator => L0000.DirectoryNameOperator.Instance;
        public static IDirectoryNames DirectoryNames => L0001.DirectoryNames.Instance;
        public static IEnumerableOperator EnumerableOperator => L0001.EnumerableOperator.Instance;
        public static IEnumerationOperator EnumerationOperator => L0001.EnumerationOperator.Instance;
        public static L0000.IEqualityComparerOperator EqualityComparerOperator => L0000.EqualityComparerOperator.Instance;
        public static L0000.IEqualityOperator EqualityOperator => L0000.EqualityOperator.Instance;
        public static IExceptionMessageOperator ExceptionMessageOperator => L0001.ExceptionMessageOperator.Instance;
        public static IExceptionOperator ExceptionOperator => L0001.ExceptionOperator.Instance;
        public static L0000.IExecutablePathOperator ExecutablePathOperator => L0000.ExecutablePathOperator.Instance;
        public static L0000.IPathOperator PathOperator => L0000.PathOperator.Instance;
        public static ISeeds Seeds => L0001.Seeds.Instance;
        public static IStringOperator StringOperator => L0001.StringOperator.Instance;
        public static ISwitchOperator SwitchOperator => L0001.SwitchOperator.Instance;
        public static ITexts Texts => L0001.Texts.Instance;
        public static L0000.ITypeOperator TypeOperator => L0000.TypeOperator.Instance;
        public static ITypeSpecifierOperator TypeSpecifierOperator => L0001.TypeSpecifierOperator.Instance;
        public static IWords Words => L0001.Words.Instance;
    }
}