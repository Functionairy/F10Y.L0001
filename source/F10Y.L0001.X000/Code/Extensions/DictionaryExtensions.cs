using System;
using System.Collections.Generic;

using Instances = F10Y.L0001.X000.Instances;


namespace System.Linq
{
    public static class DictionaryExtensions
    {
        /// <inheritdoc cref="F10Y.L0000.IDictionaryOperator.Add_Value{TKey, TValue}(IDictionary{TKey, List{TValue}}, TKey, TValue)"/>
        public static void Add_Value<TKey, TValue>(this IDictionary<TKey, List<TValue>> dictionary,
            TKey key,
            TValue value)
        {
            Instances.DictionaryOperator.Add_Value(
                dictionary,
                key,
                value);
        }

        public static Dictionary<TKey, TValue> Clone<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
            => Instances.DictionaryOperator.Clone(dictionary);

        public static Dictionary<TValue, TKey> Invert<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
            => Instances.DictionaryOperator.Invert(dictionary);

        public static Dictionary<TKey, TValue> To_Dictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> pairs)
            => Instances.DictionaryOperator.To_Dictionary(pairs);
    }
}
