using System;

using F10Y.T0003;


namespace F10Y.L0001.L002
{
    /// <summary>
    /// Boolean values useful in the context of results.
    /// (Failure/Success)
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [ValuesMarker]
    public partial interface IBooleans
    {
        /// <summary>
        /// <para><value>false</value></para>
        /// </summary>
        public bool Failure => false;

        /// <summary>
        /// <para><value>true</value></para>
        /// </summary>
        public bool Success => true;
    }
}
