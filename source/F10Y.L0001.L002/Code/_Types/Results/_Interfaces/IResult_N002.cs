using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N002
{
    /// <summary>
    /// An exceptive success, value, exception result.
    /// </summary>
    [DataTypeMarker]
    public interface IResult<T>
    {
        bool Success { get; }
        T Value { get; }
        Exception Exception { get; }
    }
}
