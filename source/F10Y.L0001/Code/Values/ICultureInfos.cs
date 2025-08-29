using System;
using System.Globalization;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001
{
    [ValuesMarker]
    public partial interface ICultureInfos :
        L0000.ICultureInfos
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.ICultureInfos _L0000 => L0000.CultureInfos.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Chooses <see cref="L0000.ICultureInfos.Invariant"/> as the Functionairy standard.
        /// </summary>
        public CultureInfo Standard => this.Invariant;
    }
}
