using System;

using F10Y.T0004;


namespace F10Y.L0001.T000
{
    /// <summary>
    /// Describes the containment (sub/super) of something.
    /// </summary>
    [DataTypeMarker]
    public enum Containment
    {
        /// <summary>
        /// Super is the default.
        /// </summary>
        Super = 0,

        Sub
    }
}
