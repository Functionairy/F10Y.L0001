using System;

using F10Y.T0002;

using F10Y.L0001.T000;


namespace F10Y.L0001.L004
{
    [FunctionsMarker]
    public partial interface ITypeSpecifierOperator
    {
        TypeSpecifier<T> From<T>()
            => TypeSpecifier<T>.Instance;

        TypeSpecifier<T1, T2> From<T1, T2>()
            => TypeSpecifier<T1, T2>.Instance;

        TypeSpecifier<T1, T2, T3> From<T1, T2, T3>()
            => TypeSpecifier<T1, T2, T3>.Instance;

        TypeSpecifier<T1> Get_First<T1, T2>(TypeSpecifier<T1, T2> typeSpecifier)
            => TypeSpecifier<T1>.Instance;

        TypeSpecifier<T2> Get_Second<T1, T2>(TypeSpecifier<T1, T2> typeSpecifier)
            => TypeSpecifier<T2>.Instance;
    }
}
