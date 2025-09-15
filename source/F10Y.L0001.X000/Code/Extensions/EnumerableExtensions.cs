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

        public static T Second<T>(this IEnumerable<T> enumerable)
        {
            var output = Instances.EnumerableOperator.Get_Second(enumerable);
            return output;
        }
    }
}
