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
        const string CommaSeparatedListSpacedSeparator_Constant = ", ";

        /// <inheritdoc cref="CommaSeparatedListSpacedSeparator_Constant"/>
        string CommaSpaceSeparatedListSeparator => IStrings.CommaSeparatedListSpacedSeparator_Constant;

        /// <inheritdoc cref="StringsDocumentation.ForTab_AsFourSpaces"/>
        const string Tab_AsFourSpaces_Constant = "    ";

        /// <inheritdoc cref="Tab_AsFourSpaces_Constant"/>
        string Tab_AsFourSpaces => IStrings.Tab_AsFourSpaces_Constant;

        /// <inheritdoc cref="Tab_AsFourSpaces_Constant"/>
        const string Tab_AsSpaces_Constant = IStrings.Tab_AsFourSpaces_Constant;

        /// <inheritdoc cref="Tab_AsSpaces_Constant"/>
        string Tab_AsSpaces => IStrings.Tab_AsSpaces_Constant;
    }
}
