using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IEqualityComparerOperator :
        L0000.IEqualityComparerOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IEqualityComparerOperator _L0000 => L0000.EqualityComparerOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        MethodBasedEqualityComparer<T> From<T>(
            Func<T, T, bool> equality_Predicate,
            Func<T, int> hashCode_Provider)
            => new MethodBasedEqualityComparer<T>(
                equality_Predicate,
                hashCode_Provider);

        MethodBasedEqualityComparer<T> Get_MethodBasedEqualityComparer<T>(
            Func<T, T, bool> equality_Predicate,
            Func<T, int> hashCode_Provider)
            => new MethodBasedEqualityComparer<T>(
                equality_Predicate,
                hashCode_Provider);
    }
}
