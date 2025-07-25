using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N004
{
    /// <summary>
    /// A noexceptive result.
    /// </summary>
    [DataTypeMarker]
    public interface IResult<T>
    {
        public bool Success { get; }
        public T Value { get; }
    }
}
