using System;

using F10Y.T0004;


namespace F10Y.L0001.T000
{
    /// <summary>
    /// Describes the inclusiveness of something.
    /// </summary>
    [DataTypeMarker]
    public enum Inclusiveness
    {
        /// <summary>
        /// Inclusive is the default.
        /// </summary>
        Inclusive = 0,

        Exclusive
    }
}
