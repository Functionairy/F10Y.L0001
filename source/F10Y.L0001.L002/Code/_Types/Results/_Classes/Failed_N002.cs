using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0001.L002.N002
{
    /// <inheritdoc cref="IFailed{T}"/>
    [DataTypeMarker]
    public class Failed<T> : IFailed<T>
    {
        public T Value { get; set; }
        public IEnumerable<string> Message_Lines { get; set; }
    }
}
