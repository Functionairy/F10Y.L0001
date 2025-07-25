using System;
using System.Collections.Generic;


namespace F10Y.L0001.L000.Extensions
{
    public static class EnumerableExtensions
    {
        public static T[] Now<T>(this IEnumerable<T> enumerable)
        {
            var output = Instances.EnumerableOperator.Now(enumerable);
            return output;
        }
    }
}
