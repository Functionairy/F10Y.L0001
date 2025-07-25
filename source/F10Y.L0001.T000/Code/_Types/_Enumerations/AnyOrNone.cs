using System;

using F10Y.T0004;


namespace F10Y.L0001.T000
{
    /// <summary>
    /// Specifies whether ANY or NONE should be used.
    /// (Useful for predicate combination generation.)
    /// </summary>
    [DataTypeMarker]
    public enum AnyOrNone
    {
        /// <summary>
        /// Any is the default.
        /// </summary>
        Any = 0,

        None,
    }
}
