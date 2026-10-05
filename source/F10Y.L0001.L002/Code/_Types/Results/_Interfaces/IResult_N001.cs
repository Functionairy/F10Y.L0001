using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N001
{
    /// <summary>
    /// A noexceptive, success, value, and message result.
    /// </summary>
    [DataTypeMarker]
    public interface IResult<T>
    {
        bool Success { get; }
        T Value { get; }
        string Message { get; }
    }
}
