using System;
using System.Collections.Generic;


namespace F10Y.L0001.L000.Extensions
{
    public static class EnumerableExtensions
    {
        public static string Join_AsList(this IEnumerable<string> strings)
            => Instances.StringOperator.Join_AsList(strings);
    }
}
