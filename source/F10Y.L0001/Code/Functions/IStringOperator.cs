using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IStringOperator :
        L000.IStringOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L000.IStringOperator _L000 => L000.StringOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
