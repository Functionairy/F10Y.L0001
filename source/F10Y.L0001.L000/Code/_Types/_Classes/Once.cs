using System;

using F10Y.T0004;


namespace F10Y.L0001.L000
{
    /// <summary>
    /// A utility type useful for keeping track of things that should happen once.
    /// </summary>
    [UtilityTypeMarker]
    public class Once
    {
        public static implicit operator bool(Once once)
            => once.Is_Unmarked;


        public bool Is_Unmarked { get; private set; } = true;


        public void Mark()
        {
            this.Is_Unmarked = false;
        }
    }
}
