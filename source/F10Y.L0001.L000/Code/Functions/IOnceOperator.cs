using System;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IOnceOperator
    {
        Once New()
            => new Once();

        void Mark(Once once)
            => once.Mark();
    }
}
