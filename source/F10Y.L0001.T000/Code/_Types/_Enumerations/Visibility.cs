using System;

using F10Y.T0004;


namespace F10Y.L0001.T000
{
    /// <summary>
    /// A public/private visibility enumeration.
    /// Default value is <see cref="Public"/>.
    /// </summary>
    /// <remarks>
    /// No unknown value.
    /// </remarks>
    [DataTypeMarker]
    public enum Visibility
    {
        /// <summary>
        /// Public by default.
        /// </summary>
        Public = 0,

        Private = 1

        // List is exhaustive, no futher values.
    }
}
