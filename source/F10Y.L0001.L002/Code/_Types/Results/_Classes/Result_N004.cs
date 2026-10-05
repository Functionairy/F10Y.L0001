using System;

using F10Y.T0004;


namespace F10Y.L0001.L002.N004
{
    /// <inheritdoc cref="IResult{T}"/>
    [DataTypeMarker]
    public class Result<T> : IResult<T>
    {
        public bool Success { get; set; }
        public T Value { get; set; }


        public override string ToString()
            => $"{this.Success}: {this.Value}";
    }
}
