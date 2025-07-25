using System;

using F10Y.T0002;


namespace F10Y.L0001.L003
{
    [FunctionsMarker]
    public partial interface ITextOperator
    {
        /// <inheritdoc cref="ITextOperator.Get_TextRepresentation_Long(string)"/>
        public string Get_TextRepresentation_Long(string @string)
            => Instances.StringOperator.Get_TextRepresentation_Long(@string);

        /// <inheritdoc cref="ITextOperator.Get_TextRepresentation_Short(string)"/>
        public string Get_TextRepresentation_Short(string @string)
            => Instances.StringOperator.Get_TextRepresentation_Short(@string);

        /// <inheritdoc cref="ITextOperator.Get_TextRepresentation(string)"/>
        public string Get_TextRepresentation(string @string)
            => Instances.StringOperator.Get_TextRepresentation(@string);
    }
}
