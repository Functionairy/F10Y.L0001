using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L004
{
    [FunctionsMarker]
    public partial interface IComparerOperator :
        L0000.IComparerOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IComparerOperator _L0000 => L0000.ComparerOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        DependencyOrderComparer<T> Get_DependencyOrderComparer<T>(
            IDictionary<T, T[]> recursiveDependencies_ByValue,
            IEqualityComparer<T> equalityComparer)
            => new DependencyOrderComparer<T>(
                recursiveDependencies_ByValue,
                equalityComparer);

        DependencyOrderComparer<T> Get_DependencyOrderComparer<T>(IDictionary<T, T[]> recursiveDependencies_ByValue)
            => this.Get_DependencyOrderComparer(
                recursiveDependencies_ByValue,
                Instances.EqualityComparers.For<T>().Default);

        DependencyOrderComparer<T> Get_DependencyOrderComparer<T>(
            IDictionary<T, HashSet<T>> recursiveDependencies_ByValue,
            IEqualityComparer<T> equalityComparer)
            => new DependencyOrderComparer<T>(
                recursiveDependencies_ByValue,
                equalityComparer);

        DependencyOrderComparer<T> Get_DependencyOrderComparer<T>(IDictionary<T, HashSet<T>> recursiveDependencies_ByValue)
            => this.Get_DependencyOrderComparer(
                recursiveDependencies_ByValue,
                Instances.EqualityComparers.For<T>().Default);

        OrderedValuesComparer<T> Get_OrderedValuesComparer<T>(
            IList<T> values,
            IEqualityComparer<T> equalityComparer)
            => new OrderedValuesComparer<T>(
                values,
                equalityComparer);

        OrderedValuesComparer<T> Get_OrderedValuesComparer<T>(IList<T> values)
            => new OrderedValuesComparer<T>(values);
    }
}
