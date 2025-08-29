using System;
using System.Collections.Generic;

using Instances = F10Y.L0001.X000.Instances;


namespace System.Linq
{
    public static class StringExtensions
    {
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
    }
}


namespace F10Y.L0001.X000
{
    public static class StringExtensions
    {
        
    }
}
