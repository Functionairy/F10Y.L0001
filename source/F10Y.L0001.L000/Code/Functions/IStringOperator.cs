using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IStringOperator :
        L0000.IStringOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IStringOperator _L0000 => L0000.StringOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Prefixes a <inheritdoc cref="L0000.ICharacters.Tab" path="descendant::description[1]"/> to the input string.
        /// </summary>
        public string Entab(string @string)
        {
            var output = this.Prefix_With(
                Instances.Characters.Tab,
                @string);

            return output;
        }

        public IEnumerable<string> Entab(IEnumerable<string> strings)
        {
            var output = strings
                .Select(this.Entab)
                ;

            return output;
        }

        public string Except_FirstTwo(string @string)
        {
            var output = @string[2..];
            return output;
        }

        public int[] Get_IndicesOf_OrEmpty(
            string @string,
            char character)
        {
            static IEnumerable<int> Internal(
                string @string,
                char specifiedCharacter)
            {
                var index = 0;
                foreach (var character in @string)
                {
                    if (character == specifiedCharacter)
                    {
                        yield return index;
                    }

                    index++;
                }
            }

            var output = Internal(
                @string,
                character)
                .ToArray();

            return output;
        }

        /// <summary>
        /// Get the index of the first token containing the specified character.
        /// If no token containing the specified character is found, return <see cref="L0000.IIndices.NotFound"/> (use with <see cref="L0000.IStringOperator.Is_Found(int)"/>).
        /// </summary>
        public int Get_TokenIndex_Containing_OrNotFound(
            IEnumerable<string> tokens,
            char character)
        {
            var counter = 0;
            foreach (var token in tokens)
            {
                var tokenContainsCharacter = Instances.StringOperator.Contains(
                    token,
                    character);

                if (tokenContainsCharacter)
                {
                    return counter;
                }
                else
                {
                    counter++;
                }
            }

            // If here, the character was not found.
            return Instances.Indices.NotFound;
        }

        /// <summary>
        /// Get the index of the first token containing the specified character.
        /// If no token containing the specified character is found, an <see cref="InvalidOperationException"/> is thrown.
        /// </summary>
        public int Get_TokenIndex_Containing(
            IEnumerable<string> tokens,
            char character)
        {
            var indexOrNotFound = this.Get_TokenIndex_Containing_OrNotFound(
                tokens,
                character);

            var isFound = this.Is_Found(indexOrNotFound);
            if (!isFound)
            {
                throw new InvalidOperationException($"{character}: character not found in any tokens.");
            }

            return indexOrNotFound;
        }

        public string Join_AsList(IEnumerable<string> strings)
        {
            var output = this.Join(
                Instances.Strings.CommaSpaceSeparatedListSeparator,
                strings);

            return output;
        }

        public string Join_AsList(params string[] strings)
        {
            var output = this.Join_AsList(strings.AsEnumerable());
            return output;
        }

        public new string Join_AsList(IEnumerable<char> characters)
        {
            var output = this.Join(
                Instances.Strings.CommaSpaceSeparatedListSeparator,
                characters);

            return output;
        }

        public string Join_AsList(params char[] characters)
        {
            var output = this.Join_AsList(characters.AsEnumerable());
            return output;
        }

        public IEnumerable<IEnumerable<string>> OrderBy_First(IEnumerable<IEnumerable<string>> values)
            => Instances.EnumerableOperator.OrderBy_First(values);

        /// <summary>
        /// Partition a string into parts given a splitting index.
        /// Exclusive in that the character at the specified index is not included in either output part.
        /// </summary>
        public (string firstPart, string secondPart) Partition_Exclusive(
            int index,
            string @string)
        {
            var firstPart = @string[0..index];
            var secondPart = @string[(index + 1)..];

            return (firstPart, secondPart);
        }

        /// <summary>
        /// Partition a string into parts given a splitting index.
        /// Inclusive in that the character at the specified index is included on the second part.
        /// </summary>
        public (string firstPart, string secondPart) Partition_Inclusive_OnSecondPart(
            int index,
            string @string)
        {
            var firstPart = @string[0..index];
            var secondPart = @string[index..];

            return (firstPart, secondPart);
        }

        /// <summary>
        /// Partition a string into parts given a splitting index.
        /// Inclusive in that the character at the specified index is included on the second part.
        /// If the index is not found, then the whole string is returned as the first part.
        /// </summary>
        public (string firstPart, string secondPart) Partition_Inclusive_OnSecondPart_OrFirstPartIfNotFound(
            int index,
            string @string)
        {
            var indexFound = this.Is_Found(index);
            if (!indexFound)
            {
                return (@string, null);
            }

            return this.Partition_Inclusive_OnSecondPart(
                index,
                @string);
        }

        /// <summary>
        /// Chooses <see cref="Partition_Exclusive(int, string)"/> as the default.
        /// </summary>
        public (string firstPart, string secondPart) Partition(
            int index,
            string @string)
        {
            return this.Partition_Exclusive(
                index,
                @string);
        }

        public IEnumerable<string> Separate(
            IEnumerable<string> strings,
            string separator)
            => Instances.EnumerableOperator.Separate(
                strings,
                separator);

        public IEnumerable<string> Separate_Lines(IEnumerable<string> lines)
            => this.Separate(
                lines,
                Instances.Strings.Empty);

        public IEnumerable<string> Separate_Many_Lines(
            IEnumerable<IEnumerable<string>> enumerable_OfLines,
            string separator)
            => Instances.EnumerableOperator.Separate_Many(
                enumerable_OfLines,
                separator);

        public IEnumerable<string> Separate_Many_Lines(IEnumerable<IEnumerable<string>> enumerable_OfLines)
            => this.Separate_Many_Lines(
                enumerable_OfLines,
                Instances.Strings.Empty);

        public IEnumerable<string> Separate_Many_Lines<T>(
            IEnumerable<T> values,
            Func<T, IEnumerable<string>> selector,
            string separator)
            => Instances.EnumerableOperator.Separate_Many<T, string>(
                values,
                selector,
                separator);

        public IEnumerable<string> Separate_Many_Lines<T>(
            IEnumerable<T> values,
            Func<T, IEnumerable<string>> selector)
            => this.Separate_Many_Lines(
                values,
                selector,
                Instances.Strings.Empty);

        /// <summary>
        /// Chooses <see cref="Partition_Exclusive(int, string)"/> as the default.
        /// </summary>
        public (string firstPart, string secondPart) Split_IntoParts(
            int index,
            string @string)
        {
            return this.Partition_Exclusive(
                index,
                @string);
        }
    }
}
