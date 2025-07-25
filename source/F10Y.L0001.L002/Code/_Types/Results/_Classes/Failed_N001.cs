using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N001
{
    /// <inheritdoc cref="IFailed{T}"/>
    [DataTypeMarker]
    public class Failed<T> : IFailed<T>
    {
        public T Value { get; set; }
        public string Message { get; set; }
    }
}
