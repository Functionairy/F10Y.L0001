using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0001.L002.N002
{
    /// <summary>
    /// A noexceptive failed result using an enumerable of message lines.
    /// </summary>
    [DataTypeMarker]
    public interface IFailed<T>
    {
        public T Value { get; }
        public IEnumerable<string> Message_Lines { get; }
    }
}
