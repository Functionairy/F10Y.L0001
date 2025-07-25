using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N006
{
    /// <summary>
    /// An exceptive result, with input and output generic type parameters.
    /// </summary>
    [DataTypeMarker]
    public interface IResult<TInput, TOutput>
    {
        bool Success { get; }
        TInput Input { get; }
        TOutput Output { get; }
        Exception Exception { get; }
    }
}
