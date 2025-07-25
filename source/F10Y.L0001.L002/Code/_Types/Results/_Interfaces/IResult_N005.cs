using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N005
{
    /// <summary>
    /// A noexceptive result.
    /// </summary>
    [DataTypeMarker]
    public interface IResult<TInput, TOutput>
    {
        bool Success { get; }
        TInput Input { get; }
        TOutput Output { get; }
    }
}
