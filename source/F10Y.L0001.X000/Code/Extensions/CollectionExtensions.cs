using System;
using System.Collections.Generic;

using Instances = F10Y.L0001.X000.Instances;


namespace System.Linq
{
    public static class CollectionExtensions
    {
        public static bool Has_Multiple<T>(this ICollection<T> collection)
            => Instances.CollectionOperator.Has_Multiple(collection);
    }
}
