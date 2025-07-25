using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N003
{
    /// <inheritdoc cref="IResult{TSuccess, TFailure}"/>
    [DataTypeMarker]
    public class Result<TSuccess, TFailure> : IResult<TSuccess, TFailure>
    {
        public bool Is_Success { get; set; }
        public TSuccess Success { get; set; }
        public TFailure Failure { get; set; }
    }
}
