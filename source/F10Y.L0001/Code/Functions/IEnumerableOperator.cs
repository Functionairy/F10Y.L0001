using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IEnumerableOperator :
        L000.IEnumerableOperator,
        L0000.IEnumerableOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L000.IEnumerableOperator _L000 => L000.EnumerableOperator.Instance;

        [Ignore]
        public new L0000.IEnumerableOperator _L0000 => L0000.EnumerableOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        
    }
}
