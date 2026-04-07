using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IMappingsOperator
    {
        Dictionary<T, T[]> Get_RecursiveMappings_Inclusive<T>(
            Dictionary<T, T[]> directMappings,
            IEqualityComparer<T> equalityComparer,
            out T[] missingKeys)
        {
            var recursiveMappings_Exclusive = this.Get_RecursiveMappings_Exclusive(
                directMappings,
                equalityComparer,
                out missingKeys);

            var output = recursiveMappings_Exclusive
                .ToDictionary(
                    pair => pair.Key,
                    pair => pair.Value.Prepend(pair.Key).ToArray());

            return output;
        }

        Dictionary<T, T[]> Get_RecursiveMappings_Inclusive<T>(
            Dictionary<T, T[]> directMappings,
            out T[] missingKeys)
            => this.Get_RecursiveMappings_Inclusive(
                directMappings,
                Instances.EqualityComparers.For<T>().Default,
                out missingKeys);

        /// <summary>
        /// Gets the recursive values of all mappings.
        /// </summary>
        Dictionary<T, T[]> Get_RecursiveMappings_Exclusive<T>(
            Dictionary<T, T[]> directMappings,
            IEqualityComparer<T> equalityComparer,
            out T[] missingKeys)
        {
            var output = Instances.DictionaryOperator.New<T, T[]>(equalityComparer);

            var keys = directMappings.Keys;

            var missingKeys_Hash = Instances.HashSetOperator.New(equalityComparer);

            foreach (var key in keys)
            {
                var values_Recursive = Instances.HashSetOperator.New(equalityComparer);

                this.Get_Values_Recursive(
                    key,
                    directMappings,
                    values_Recursive,
                    missingKeys_Hash);

                var values = Instances.HashSetOperator.To_Array(values_Recursive);

                output.Add(
                    key,
                    values);
            }

            missingKeys = Instances.HashSetOperator.To_Array(missingKeys_Hash);

            return output;
        }

        Dictionary<T, T[]> Get_RecursiveMappings_Exclusive<T>(
            Dictionary<T, T[]> directMappings,
            out T[] missingKeys)
            => this.Get_RecursiveMappings_Exclusive(
                directMappings,
                Instances.EqualityComparers.For<T>().Default,
                out missingKeys);

        void Get_Values_Recursive<T>(
            T key,
            Dictionary<T, T[]> directMappings,
            HashSet<T> values_Recursive,
            HashSet<T> missingKeys)
        {
            var mappings_ContainsKey = directMappings.ContainsKey(key);
            if (!mappings_ContainsKey)
            {
                missingKeys.Add(key);

                return;
            }

            var values_ForKey = directMappings[key];

            // Foreach value that is not currently in the recursive mappings, recurse.
            foreach (var value in values_ForKey)
            {
                var alreadyHandled = values_Recursive.Contains(value);
                if (!alreadyHandled)
                {
                    values_Recursive.Add(value);

                    this.Get_Values_Recursive(
                        value,
                        directMappings,
                        values_Recursive,
                        missingKeys);
                }
            }
        }
    }
}
