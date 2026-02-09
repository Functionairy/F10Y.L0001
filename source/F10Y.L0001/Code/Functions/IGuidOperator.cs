using System;

using F10Y.T0002;
using F10Y.T0011;

using GuidDocumentation = F10Y.Y0000.Documentation.For_Guid;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IGuidOperator :
        L004.IGuidOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L004.IGuidOperator _L004 => L004.GuidOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
