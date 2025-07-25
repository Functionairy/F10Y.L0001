using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IEnumerableOperator
    {
        /// <summary>
        /// Evaluates the given enumerable <em>now</em>.
        /// </summary>
        /// <remarks>
        /// A quality-of-life overload for <see cref="Enumerable.ToArray{TSource}(IEnumerable{TSource})"/>.
        /// </remarks>
        public T[] Now<T>(IEnumerable<T> enumerable)
        {
            var output = enumerable.ToArray();
            return output;
        }
    }
}
