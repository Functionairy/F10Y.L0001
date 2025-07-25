using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001.L003
{
    [ValuesMarker]
    public partial interface ITextRepresentations
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.ITextRepresentations _Raw => Raw.TextRepresentations.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.ITextRepresentations.N_001"/>
        public string For_Empty => _Raw.N_001;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_002"/>
        public string For_CarriageReturn_Long => _Raw.N_002;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_008"/>
        public string For_CarriageReturn_Short => _Raw.N_008;

        /// <inheritdoc cref="For_CarriageReturn_Short"/>
        public string For_CarriageReturn => this.For_CarriageReturn_Short;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_003"/>
        public string For_Newline_Long => _Raw.N_003;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_009"/>
        public string For_Newline_Short => _Raw.N_009;

        /// <inheritdoc cref="For_Newline_Short"/>
        public string For_NewLine => this.For_Newline_Short;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_012"/>
        public string For_None => _Raw.N_012;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_004"/>
        public string For_Null => _Raw.N_004;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_005"/>
        public string For_Space_Long => _Raw.N_005;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_010"/>
        public string For_Space_Short => _Raw.N_010;

        /// <inheritdoc cref="For_Space_Short"/>
        public string For_Space => this.For_Space_Short;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_006"/>
        public string For_Tab_Long => _Raw.N_006;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_011"/>
        public string For_Tab_Short => _Raw.N_011;

        /// <inheritdoc cref="For_Tab_Short"/>
        public string For_Tab => this.For_Tab_Short;

        /// <inheritdoc cref="Raw.ITextRepresentations.N_007"/>
        public string For_Unknown => _Raw.N_007;
    }
}
