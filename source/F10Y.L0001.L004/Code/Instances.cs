using System;


namespace F10Y.L0001.L004
{
    public static class Instances
    {
        public static Z000.ISeeds Seeds => Z000.Seeds.Instance;
        public static ITypeSpecifierOperator TypeSpecifierOperator => L004.TypeSpecifierOperator.Instance;
    }
}