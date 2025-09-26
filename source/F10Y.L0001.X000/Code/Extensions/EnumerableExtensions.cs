using System;
using System.Collections.Generic;

using Instances = F10Y.L0001.X000.Instances;


namespace System.Linq
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Append<T>(this IEnumerable<T> enumerable,
            IEnumerable<T> appendix)
        {
            var output = Instances.EnumerableOperator.Append(
                enumerable,
                appendix);

            return output;
        }

        public static IEnumerable<T> Append<T>(this IEnumerable<T> enumerable,
            params T[] appendix)
        {
            var output = Instances.EnumerableOperator.Append(
                enumerable,
                appendix);

            return output;
        }

        public static IEnumerable<T> Append_If<T>(this IEnumerable<T> enumerable,
            bool condition,
            IEnumerable<T> appendix)
            => Instances.EnumerableOperator.Append_If(
                enumerable,
                condition,
                appendix);

        public static IEnumerable<T> Append_If<T>(this IEnumerable<T> enumerable,
            bool condition,
            params T[] appendix)
            => Instances.EnumerableOperator.Append_If(
                enumerable,
                condition,
                appendix);

        public static IEnumerable<T> Append_If<T>(this IEnumerable<T> enumerable,
            bool condition,
            IEnumerable<T> appendix_IfTrue,
            IEnumerable<T> appendix_IfFalse)
            => Instances.EnumerableOperator.Append_If(
                enumerable,
                condition,
                appendix_IfTrue,
                appendix_IfFalse);

        public static IEnumerable<T> Append_If<T>(this IEnumerable<T> enumerable,
            bool condition,
            Func<IEnumerable<T>> get_Appendix_IfTrue,
            Func<IEnumerable<T>> get_Appendix_IfFalse)
            => Instances.EnumerableOperator.Append_If(
                enumerable,
                condition,
                get_Appendix_IfTrue,
                get_Appendix_IfFalse);

        public static IEnumerable<T> Append_Many<T>(this IEnumerable<T> enumerable,
            IEnumerable<T> appendix)
        {
            var output = Instances.EnumerableOperator.Append_Many(
                enumerable,
                appendix);

            return output;
        }

        public static IEnumerable<T> Except<T>(this IEnumerable<T> items,
            T item)
            where T : IEquatable<T>
        {
            var output = Instances.EnumerableOperator.Except(items,
                item);

            return output;
        }

        public static IEnumerable<T> Except<T>(this IEnumerable<T> items,
            T item,
            IEqualityComparer<T> equalityComparer)
            where T : IEquatable<T>
        {
            var output = Instances.EnumerableOperator.Except(items,
                item,
                equalityComparer);

            return output;
        }

        public static T[] Now<T>(this IEnumerable<T> enumerable)
        {
            var output = Instances.EnumerableOperator.Now(enumerable);
            return output;
        }

        public static IEnumerable<T> Order_ByNames<T>(this IEnumerable<T> items,
            Func<T, string> nameSelector,
            IEnumerable<string> orderedNames)
        {
            var output = Instances.OrderOperator.Order_ByNames(
                items,
                nameSelector,
                orderedNames);

            return output;
        }

        public static IEnumerable<T> Order_ByNames<T>(this IEnumerable<T> items,
            Func<T, string> nameSelector,
            params string[] orderedNames)
        {
            return items.Order_ByNames(
                nameSelector,
                orderedNames.AsEnumerable());
        }

        public static IEnumerable<T> Order_Ascending<T>(this IEnumerable<T> enumerable,
            Comparer<T> comparer)
            => Instances.EnumerableOperator.Order_Ascending(
                enumerable,
                comparer);

        public static IEnumerable<T> Order_Descending<T>(this IEnumerable<T> enumerable,
            Comparer<T> comparer)
            => Instances.EnumerableOperator.Order_Descending(
                enumerable,
                comparer);

        public static IEnumerable<T> Order<T>(this IEnumerable<T> enumerable,
            Comparer<T> comparer)
            => Instances.EnumerableOperator.Order(
                enumerable,
                comparer);

        public static IEnumerable<T> Order_Ascending_With<T>(this IEnumerable<T> enumerable,
            Comparison<T> comparison)
            => Instances.EnumerableOperator.Order_Ascending_With(
                enumerable,
                comparison);

        public static IEnumerable<T> Order_Descending_With<T>(this IEnumerable<T> enumerable,
            Comparison<T> comparison)
            => Instances.EnumerableOperator.Order_Descending_With(
                enumerable,
                comparison);

        public static IEnumerable<T> Order_With<T>(this IEnumerable<T> enumerable,
            Comparison<T> comparison)
            => Instances.EnumerableOperator.Order_With(
                enumerable,
                comparison);

        public static IOrderedEnumerable<T> Order_By<T, TKey>(this IEnumerable<T> enumerable,
            Func<T, TKey> key_Selector,
            Comparison<TKey> key_Comparison)
            => Instances.EnumerableOperator.Order_By(enumerable,
                key_Selector,
                key_Comparison);

        public static T Second<T>(this IEnumerable<T> enumerable)
        {
            var output = Instances.EnumerableOperator.Get_Second(enumerable);
            return output;
        }
    }
}
