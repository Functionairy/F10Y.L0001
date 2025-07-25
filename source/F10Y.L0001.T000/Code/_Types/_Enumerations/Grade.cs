using System;

using F10Y.T0004;


namespace F10Y.L0001.T000
{
    /// <summary>
    /// An upgrade/downgrade enumeration.
    /// Default value is <see cref="Upgrade"/>.
    /// </summary>
    /// <remarks>
    /// A bi-valued grade enumeration.
    /// </remarks>
    [DataTypeMarker]
    public enum Grade
    {
        /// <summary>
        /// Upgrade by default.
        /// </summary>
        Upgrade = 0,

        Downgrade = 1

        // List is exhaustive, no futher values.
    }
}
