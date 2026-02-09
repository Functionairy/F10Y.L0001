using System;

using F10Y.T0002;
using F10Y.T0011;

using F10Y.L0001.T000;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface ITypeOperator :
        L000.ITypeOperator,
        L004.ITypeOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        new L000.ITypeOperator _L000 => L000.TypeOperator.Instance;

        [Ignore]
        L004.ITypeOperator _L004 => L004.TypeOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
