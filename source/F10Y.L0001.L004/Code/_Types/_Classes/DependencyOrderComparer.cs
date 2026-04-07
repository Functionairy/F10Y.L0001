using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0004;


namespace F10Y.L0001.L004
{
    [UtilityTypeMarker]
    public class DependencyOrderComparer<T> : IComparer<T>
    {
        private Dictionary<T, HashSet<T>> RecursiveDependencies_ByValue { get; set; }


        public DependencyOrderComparer(
            IDictionary<T, T[]> recursiveDependencies_ByValue,
            IEqualityComparer<T> equalityComparer)
        {
            this.RecursiveDependencies_ByValue = recursiveDependencies_ByValue
                .ToDictionary(
                    pair => pair.Key,
                    pair => Instances.HashSetOperator.From_KeepFirst(
                        pair.Value,
                        equalityComparer),
                    equalityComparer);
        }

        public DependencyOrderComparer(
            IDictionary<T, HashSet<T>> recursiveDependencies_ByValue,
            IEqualityComparer<T> equalityComparer)
        {
            this.RecursiveDependencies_ByValue = Instances.DictionaryOperator.To_Dictionary(
                recursiveDependencies_ByValue,
                equalityComparer);
        }

        public int Compare(T x, T y)
        {
            // Ensure that an entry exists for both.
            var hasX = this.RecursiveDependencies_ByValue.ContainsKey(x);
            if (!hasX)
            {
                throw Instances.ExceptionOperator.From($"Misconfigured comparer: No dependencies set found for item '{x}'.");
            }

            var hasY = this.RecursiveDependencies_ByValue.ContainsKey(y);
            if (!hasY)
            {
                throw Instances.ExceptionOperator.From($"Misconfigured comparer: No dependencies set found for item '{y}'.");
            }

            // If Y appears in the dependencies of X, then X is *more* dependent than Y.
            var xHasY = this.RecursiveDependencies_ByValue[x].Contains(y);
            if (xHasY)
            {
                return Instances.ComparisonResults.GreaterThan;
            }

            // If X appears in the dependencies of Y, then Y is *more* dependent than X.
            var yHasX = this.RecursiveDependencies_ByValue[y].Contains(x);
            if (yHasX)
            {
                return Instances.ComparisonResults.LessThan;
            }

            // Else.
            return Instances.ComparisonResults.EqualTo;
        }
    }
}
