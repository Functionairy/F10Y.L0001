using System;


namespace F10Y.L0001.L004
{
    public class TypeSpecifierOperator : ITypeSpecifierOperator
    {
        #region Infrastructure

        public static ITypeSpecifierOperator Instance { get; } = new TypeSpecifierOperator();


        private TypeSpecifierOperator()
        {
        }

        #endregion
    }
}
