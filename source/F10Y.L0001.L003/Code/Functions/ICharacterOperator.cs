using System;

using F10Y.T0002;
using F10Y.T0011;

using ICharacters = F10Y.L0000.ICharacters;


namespace F10Y.L0001.L003
{
    [FunctionsMarker]
    public partial interface ICharacterOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private static ITextRepresentations _TextRepresentations => TextRepresentations.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// If the characters is one of several whitespace values (space, newline, tab, etc.), outputs a string representation of that character instead of the character itself as a string.
        /// Otherwise just returns the text.
        /// <para>
        /// Gets the long text representations (<inheritdoc cref="ITextRepresentations.For_Newline_Long" path="descendant::value"/> instead of <inheritdoc cref="ITextRepresentations.For_Newline_Short" path="descendant::value"/>).
        /// </para>
        /// </summary>
        // See also: R5T.L0053.ItextOperator.
        public string Get_TextRepresentation_Long(char character)
        {
            var output = character switch
            {
                ICharacters.CarriageReturn_Constant => _TextRepresentations.For_CarriageReturn_Long,
                ICharacters.NewLine_Constant => _TextRepresentations.For_Newline_Long,
                ICharacters.Space_Constant => _TextRepresentations.For_Space_Long,
                ICharacters.Tab_Constant => _TextRepresentations.For_Tab_Long,
                _ => character.ToString()
            };

            return output;
        }

        /// <summary>
        /// If the characters is one of several whitespace values (space, newline, tab, etc.), outputs a string representation of that character instead of the character itself as a string.
        /// Otherwise just returns the text.
        /// <para>
        /// Gets the short text representations (<inheritdoc cref="ITextRepresentations.For_Newline_Short" path="descendant::value"/> instead of <inheritdoc cref="ITextRepresentations.For_Newline_Long" path="descendant::value"/>).
        /// </para>
        /// </summary>
        // See also: R5T.L0053.ItextOperator.
        public string Get_TextRepresentation_Short(char character)
        {
            var output = character switch
            {
                ICharacters.CarriageReturn_Constant => _TextRepresentations.For_CarriageReturn_Short,
                ICharacters.NewLine_Constant => _TextRepresentations.For_Newline_Short,
                ICharacters.Space_Constant => _TextRepresentations.For_Space_Short,
                ICharacters.Tab_Constant => _TextRepresentations.For_Tab_Short,
                _ => character.ToString()
            };

            return output;
        }
    }
}
