using System;

using F10Y.T0004;


namespace F10Y.L0001.T000
{
    /// <summary>
    /// Describes the contiguity of something.
    /// </summary>
    [DataTypeMarker]
    public enum Contiguity
    {
        /// <summary>
        /// Contiguous is the default.
        /// </summary>
        Contiguous = 0,

        Noncontiguous
    }
}
