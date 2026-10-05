using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N004
{
    /// <summary>
    /// A noexceptive result (success and value).
    /// </summary>
    [DataTypeMarker]
    public interface IResult<T>
    {
        bool Success { get; }
        T Value { get; }
    }
}
