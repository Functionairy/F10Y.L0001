using System;
using System.Collections.Generic;

using Instances = F10Y.L0001.X000.Instances;


namespace System.Linq
{
    public static class StringExtensions
    {
        public static IEnumerable<string> Append_BlankLine(this IEnumerable<string> strings)
        {
            var output = Instances.EnumerableOperator.Append(
                strings,
                Instances.Strings.Empty);

            return output;
        }

        public static string Entab(this string @string)
        {
            var output = Instances.StringOperator.Entab(@string);
            return output;
        }

        /// <inheritdoc cref="F10Y.L0001.L000.IStringOperator.Entab(string)"/>
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

        public static string Join(this IEnumerable<string> strings,
            char separator)
        {
            var output = Instances.StringOperator.Join(
                separator,
                strings);

            return output;
        }

        public static string Join(this IEnumerable<string> strings,
            string separator)
        {
            var output = Instances.StringOperator.Join(
                separator,
                strings);

            return output;
        }

        public static string Join(this IEnumerable<string> strings)
        {
            var output = Instances.StringOperator.Join(
                Instances.Strings.Empty,
                strings);

            return output;
        }

        public static string Join_Lines(this IEnumerable<string> strings)
            => Instances.TextOperator.Join_Lines(strings);

        public static string Join_ToString(this IEnumerable<string> strings)
            => Instances.StringOperator.Join_ToString(strings);

        public static string Join_ToString(this string[] strings)
            => Instances.StringOperator.Join_ToString(strings);

        public static IEnumerable<string> Order_Alphabetically(this IEnumerable<string> strings)
        {
            var output = Instances.StringOperator.Order_Alphabetically(strings);
            return output;
        }

        public static IEnumerable<T> Order_AlphabeticallyBy<T>(this IEnumerable<T> values,
            Func<T, string> selector)
        {
            var output = Instances.StringOperator.Order_AlphabeticallyBy(
                values,
                selector);

            return output;
        }

        public static IEnumerable<IEnumerable<string>> OrderBy_First(this IEnumerable<IEnumerable<string>> values)
            => Instances.StringOperator.OrderBy_First(values);

        public static string Prefix_With(this string @string,
            char prefix)
            => Instances.StringOperator.Prefix_With(
                prefix,
                @string);

        public static IEnumerable<string> Separate_Lines(this IEnumerable<string> lines)
            => Instances.StringOperator.Separate_Lines(lines);

        public static IEnumerable<string> SeparateMany_Lines(this IEnumerable<IEnumerable<string>> values)
            => Instances.StringOperator.Separate_Many_Lines(values);

        public static IEnumerable<string> SeparateMany_Lines<T>(this IEnumerable<T> values,
            Func<T, IEnumerable<string>> selector)
            => Instances.StringOperator.Separate_Many_Lines(
                values,
                selector);

        public static IEnumerable<string> SeparateMany_Lines<T>(this IEnumerable<T> values,
           Func<T, int, IEnumerable<string>> selector)
           => Instances.StringOperator.Separate_Many_Lines(
               values,
               selector);

        public static string Wrap(this string @string,
            string prefix,
            string suffix)
        {
            return Instances.StringOperator.Wrap(
                @string,
                prefix,
                suffix);
        }

        /// <inheritdoc cref="F10Y.L0000.IStringOperator.Trim(string)"/>
        public static IEnumerable<string> Trim(this IEnumerable<string> strings)
        {
            var output = Instances.StringOperator.Trim(strings);
            return output;
        }

        /// <inheritdoc cref="F10Y.L0000.IStringOperator.Trim(string)"/>
        public static IEnumerable<string> Trim(this IEnumerable<string> strings,
            params char[] characters)
        {
            var output = Instances.StringOperator.Trim(
                strings,
                characters);

            return output;
        }

        public static string Wrap(this string @string,
            char prefix,
            char suffix)
        {
            return Instances.StringOperator.Wrap(
                @string,
                prefix,
                suffix);
        }
    }
}


namespace F10Y.L0001.X000
{
    public static class StringExtensions
    {
        
    }
}
