using System;
using System.Collections.Generic;

using Instances = F10Y.L0001.X000.Instances;


namespace System.Linq
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
