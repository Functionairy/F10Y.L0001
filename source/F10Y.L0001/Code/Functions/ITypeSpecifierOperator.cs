using System;

using F10Y.T0002;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface ITypeSpecifierOperator
    {
        TypeSpecifier<T1> Get_First<T1, T2>(TypeSpecifier<T1, T2> typeSpecifier)
            => TypeSpecifier<T1>.Instance;

        TypeSpecifier<T2> Get_Second<T1, T2>(TypeSpecifier<T1, T2> typeSpecifier)
            => TypeSpecifier<T2>.Instance;
    }
}
