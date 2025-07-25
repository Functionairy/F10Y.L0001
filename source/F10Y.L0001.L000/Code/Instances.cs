using System;


namespace F10Y.L0001.L000
{
    public static class Instances
    {
        public static L0000.ICharacters Characters => L0000.Characters.Instance;
        public static IEnumerableOperator EnumerableOperator => L000.EnumerableOperator.Instance;
        public static IStringOperator StringOperator => L000.StringOperator.Instance;
    }
}