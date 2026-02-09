using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IArrayOperator :
        L0000.IArrayOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IArrayOperator _L0000 => L0000.ArrayOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Does the parent set contain the given set?
        /// </summary>
        public bool Contains_Contiguous_OrderIndependent<T>(
            T[] parent,
            T[] set,
            IEqualityComparer<T> equalityComparer)
        {
            var length_A = this.Get_Length(parent);
            var length_B = this.Get_Length(set);

            var subsection_OfA = this.New<T>(length_B);

            var first_B = this.Get_First(set);

            for (int i = 0; i < length_A; i++)
            {
                var element_A = parent[i];

                var equals_FirstB = equalityComparer.Equals(element_A, first_B);
                if (equals_FirstB)
                {
                    // Are there enough elements left?
                    var remainingElementCount_A = length_A - i;
                    if (remainingElementCount_A < length_B)
                    {
                        return false;
                    }

                    this.Copy(
                        parent,
                        subsection_OfA,
                        i);

                    var areEqual_OrderIndependent = this.Are_Equal_OrderIndependent(
                        set,
                        subsection_OfA,
                        equalityComparer);

                    if(areEqual_OrderIndependent)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <inheritdoc cref="Contains_Contiguous_OrderIndependent{T}(T[], T[], IEqualityComparer{T})"/>
        public bool Contains_Contiguous_OrderIndependent<T>(
            T[] parent,
            T[] set)
            where T : IEquatable<T>
        {
            var equalityComparer = Instances.EqualityComparerOperator.Get_Default<T>();

            var output = this.Contains_Contiguous_OrderIndependent(
                parent,
                set,
                equalityComparer);

            return output;
        }

        /// <summary>
        /// Does the parent set contain the given set?
        /// </summary>
        public bool Contains_NonContiguous_OrderIndependent<T>(
            T[] parent,
            T[] set,
            IEqualityComparer<T> equalityComparer)
        {
            var length_A = this.Get_Length(parent);

            var counts_ByUniqueValue = set.GroupBy(
                x => x,
                equalityComparer)
                .ToDictionary(
                    group => group.Key,
                    group => group.Count());

            for (int i = 0; i < length_A; i++)
            {
                var element_A = parent[i];

                var containsElement_A = counts_ByUniqueValue.ContainsKey(element_A);
                if(containsElement_A)
                {
                    var count_OfElementA = counts_ByUniqueValue[element_A];

                    count_OfElementA--;

                    if(count_OfElementA == 0)
                    {
                        counts_ByUniqueValue.Remove(element_A);
                    }
                    else
                    {
                        counts_ByUniqueValue[element_A] = count_OfElementA;
                    }

                    if(counts_ByUniqueValue.Count == 0)
                    {
                        // Success! All elements accounted for.
                        return true;
                    }
                }
            }

            return false;
        }

        /// <inheritdoc cref="Contains_NonContiguous_OrderIndependent{T}(T[], T[], IEqualityComparer{T})"/>
        public bool Contains_NonContiguous_OrderIndependent<T>(
            T[] parent,
            T[] set)
            where T : IEquatable<T>
        {
            var equalityComparer = Instances.EqualityComparerOperator.Get_Default<T>();

            var output = this.Contains_NonContiguous_OrderIndependent(
                parent,
                set,
                equalityComparer);

            return output;
        }

        /// <summary>
        /// Does A contain B?
        /// </summary>
        public bool Contains_NonContiguous_OrderDependent<T>(
            T[] parent,
            T[] set,
            Func<T, T, bool> equality)
        {
            var length_A = this.Get_Length(parent);
            var length_B = this.Get_Length(set);

            var index_InB = this.Get_Index_First(set);
            var element_B = set[index_InB];

            for (int i = 0; i < length_A; i++)
            {
                var element_A = parent[i];

                var equals_B = equality(element_A, element_B);
                if (equals_B)
                {
                    index_InB++;

                    if (index_InB < length_B)
                    {
                        element_B = set[index_InB];
                    }
                    else
                    {
                        // Success! We made it all the way through B.
                        return true;
                    }
                }
            }

            return false;
        }

        /// <inheritdoc cref="Contains_NonContiguous_OrderDependent{T}(T[], T[], Func{T, T, bool})"/>
        public bool Contains_NonContiguous_OrderDependent<T>(
            T[] parent,
            T[] set)
            where T : IEquatable<T>
        {
            var equality = Instances.EqualityOperator.Get_Equality<T>();

            var output = this.Contains_NonContiguous_OrderDependent(
                parent,
                set,
                equality);

            return output;
        }
    }
}
