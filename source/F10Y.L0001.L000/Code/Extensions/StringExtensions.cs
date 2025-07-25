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
    }
}
