using System;
using System.Collections.Generic;

using Instances = F10Y.L0001.X000.Instances;


namespace System.Linq
{
    public static class HashSetExtensions
    {
        /// <summary>
        /// Chooses <see cref="F10Y.L0000.IHashSetOperator.Add_Range_KeepLast{T}(HashSet{T}, IEnumerable{T})"/> as the default behavior (which it is for <see cref="HashSet{T}"/>).
        /// Idempotent.
        /// </summary>
        public static HashSet<T> Add_Range<T>(this HashSet<T> hashSet,
            IEnumerable<T> items)
        {
            var output = Instances.HashSetOperator.Add_Range(
                hashSet,
                items);

            return output;
        }
    }
}
