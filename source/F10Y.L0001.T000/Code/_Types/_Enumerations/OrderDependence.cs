using System;

using F10Y.T0004;


namespace F10Y.L0001.T000
{
    /// <summary>
    /// Describes the order dependence of something.
    /// </summary>
    [DataTypeMarker]
    public enum OrderDependence
    {
        /// <summary>
        /// Order dependent is the default.
        /// </summary>
        OrderDependent = 0,

        OrderIndependent
    }
}
