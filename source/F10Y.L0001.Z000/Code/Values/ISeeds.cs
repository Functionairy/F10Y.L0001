using System;

using F10Y.T0003;


namespace F10Y.L0001.Z000
{
    [ValuesMarker]
    public partial interface ISeeds
    {
        /// <inheritdoc cref="Pi_Constant"/>
        public const int Default_Constant = ISeeds.Pi_Constant;

        /// <inheritdoc cref="Default_Constant"/>
        public int Default => ISeeds.Default_Constant;

        /// <summary>
        /// <para><description><value>31415</value>, the first five digits of pi, as an integer.</description></para>
        /// </summary>
        public const int Pi_Constant = 31415;

        /// <inheritdoc cref="Pi_Constant"/>
        public int Pi => ISeeds.Pi_Constant;
    }
}
