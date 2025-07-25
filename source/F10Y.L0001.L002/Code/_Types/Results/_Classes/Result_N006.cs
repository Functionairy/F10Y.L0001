using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N006
{
    /// <inheritdoc cref="IResult{TInput, TOutput}"/>
    [DataTypeMarker]
    public class Result<TInput, TOutput> : IResult<TInput, TOutput>
    {
        public bool Success { get; set; }
        public TInput Input { get; set; }
        public TOutput Output { get; set; }
        public Exception Exception { get; set; }
    }
}
 