using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    using StringsDocumentation = Documentation.For_Strings;


    [ValuesMarker]
    public partial interface IStrings :
        L0000.IStrings
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IStrings _L0000 => L0000.Strings.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="StringsDocumentation.ForCommaSeparatedListSpacedSeparator"/>
        public const string CommaSeparatedListSpacedSeparator_Constant = ", ";

        /// <inheritdoc cref="CommaSeparatedListSpacedSeparator_Constant"/>
        public string CommaSpaceSeparatedListSeparator => IStrings.CommaSeparatedListSpacedSeparator_Constant;
    }
}
