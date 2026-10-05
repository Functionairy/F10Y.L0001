using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L003
{
    [FunctionsMarker]
    public partial interface ITextOperator :
        L0000.ITextOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.ITextOperator _L0000 => L0000.TextOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="ITextOperator.Get_TextRepresentation_Long(string)"/>
        string Get_TextRepresentation_Long(string @string)
            => Instances.StringOperator.Get_TextRepresentation_Long(@string);

        /// <inheritdoc cref="ITextOperator.Get_TextRepresentation_Short(string)"/>
        string Get_TextRepresentation_Short(string @string)
            => Instances.StringOperator.Get_TextRepresentation_Short(@string);

        /// <inheritdoc cref="ITextOperator.Get_TextRepresentation(string)"/>
        string Get_TextRepresentation(string @string)
            => Instances.StringOperator.Get_TextRepresentation(@string);
    }
}
