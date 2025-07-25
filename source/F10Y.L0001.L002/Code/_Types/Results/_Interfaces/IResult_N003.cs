using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N003
{
    /// <summary>
    /// A bifurcated result.
    /// </summary>
    [DataTypeMarker]
    public interface IResult<TSuccess, TFailure>
    {
        public bool Is_Success { get; }
        public TSuccess Success { get; }
        public TFailure Failure { get; }
    }
}
