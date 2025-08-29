using System;
using System.Collections.Generic;


namespace F10Y.L0001.L000.Extensions
{
    public static  class StringExtensions
    {
        public static string Entab(this string @string)
        {
            var output = Instances.StringOperator.Entab(@string);
            return output;
        }

        /// <inheritdoc cref="IStringOperator.Entab(string)"/>
        public static IEnumerable<string> Entab(this IEnumerable<string> strings)
        {
            var output = Instances.StringOperator.Entab(strings);
            return output;
        }

        public static string Except_First(this string @string)
        {
            return Instances.StringOperator.Except_First(@string);
        }

        public static string Except_FirstTwo(this string @string)
        {
            var output = Instances.StringOperator.Except_FirstTwo(@string);
            return output;
        }

        public static IEnumerable<string> Separate_Lines(this IEnumerable<string> lines)
            => Instances.StringOperator.Separate_Lines(lines);

        public static IEnumerable<string> SeparateMany_Lines(this IEnumerable<IEnumerable<string>> values)
            => Instances.StringOperator.Separate_Many_Lines(values);

        public static IEnumerable<string> SeparateMany_Lines<T>(this IEnumerable<T> values,
            Func<T, IEnumerable<string>> selector)
            => Instances.StringOperator.Separate_Many_Lines(
                values,
                selector);
    }
}
