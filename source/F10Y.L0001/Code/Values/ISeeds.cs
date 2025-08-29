using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001
{
    [ValuesMarker]
    public partial interface ISeeds :
        Z000.ISeeds
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Z000.ISeeds _Z000 => Z000.Seeds.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Chooses <see cref="Z000.ISeeds.Pi_Constant"/> as the Functionairy standard.
        /// </summary>
        public const int Standard_Constant = Z000.ISeeds.Pi_Constant;

        /// <summary>
        /// Chooses <see cref="Z000.ISeeds.Pi"/> as the Functionairy standard.
        /// </summary>
        public int Standard => this.Pi;
    }
}
