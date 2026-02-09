using System;

using F10Y.T0002;

using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface ITypeSpecifierOperator :
        L004.ITypeSpecifierOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L004.ITypeSpecifierOperator _L004 => L004.TypeSpecifierOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
