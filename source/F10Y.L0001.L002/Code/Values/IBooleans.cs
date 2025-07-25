using System;

using F10Y.T0003;


namespace F10Y.L0001.L002
{
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
