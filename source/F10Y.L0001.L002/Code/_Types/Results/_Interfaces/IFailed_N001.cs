using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N001
{
    /// <summary>
    /// A noexceptive failed result.
    /// </summary>
    [DataTypeMarker]
    public interface IFailed<T>
    {
        public T Value { get; }
        public string Message { get; }
    }
}
