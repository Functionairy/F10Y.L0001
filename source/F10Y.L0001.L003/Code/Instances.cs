using System;


namespace F10Y.L0001.L003
{
    public static class Instances
    {
        public static ICharacterOperator CharacterOperator => L003.CharacterOperator.Instance;
        public static IStringOperator StringOperator => L003.StringOperator.Instance;
        public static ITextRepresentations TextRepresentations => L003.TextRepresentations.Instance;
    }
}