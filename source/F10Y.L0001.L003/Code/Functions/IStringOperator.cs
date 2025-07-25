using System;
using System.Linq;

using F10Y.L0000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L003
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
        /// Gets the long text representations (<inheritdoc cref="ITextRepresentations.For_Newline_Long" path="descendant::value"/> instead of <inheritdoc cref="ITextRepresentations.For_Newline_Short" path="descendant::value"/>).
        /// </summary>
        public string Get_TextRepresentation_Long(string @string)
        {
            var isNull = Instances.StringOperator.Is_Null(@string);
            if (isNull)
            {
                return Instances.TextRepresentations.For_Null;
            }

            var isEmpty = Instances.StringOperator.Is_Empty(@string);
            if (isEmpty)
            {
                return Instances.TextRepresentations.For_Empty;
            }

            var output = @string
                .Select(Instances.CharacterOperator.Get_TextRepresentation_Long)
                .Join_ToString();

            return output;
        }

        /// <summary>
        /// Gets the short text representations (<inheritdoc cref="ITextRepresentations.For_Newline_Short" path="descendant::value"/> instead of <inheritdoc cref="ITextRepresentations.For_Newline_Long" path="descendant::value"/>).
        /// </summary>
        public string Get_TextRepresentation_Short(string @string)
        {
            var isNull = Instances.StringOperator.Is_Null(@string);
            if (isNull)
            {
                return Instances.TextRepresentations.For_Null;
            }

            var isEmpty = Instances.StringOperator.Is_Empty(@string);
            if (isEmpty)
            {
                return Instances.TextRepresentations.For_Empty;
            }

            var output = @string
                .Select(Instances.CharacterOperator.Get_TextRepresentation_Short)
                .Join_ToString();

            return output;
        }

        /// <inheritdoc cref="Get_TextRepresentation_Short(string)" path="/summary"/>
        /// <remarks>
        /// Chooses <see cref="Get_TextRepresentation_Short(string)"/> as the default.
        /// </remarks>
        public string Get_TextRepresentation(string @string)
            => this.Get_TextRepresentation_Short(@string);
    }
}
