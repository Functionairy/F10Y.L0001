using System;
using System.Collections;
using System.Collections.Generic;


namespace F10Y.L0001.T000
{
    public abstract class EnumerableBase<T> : IEnumerable<T>
    {
        protected abstract T[] Values_ForEnumerable { get; }


        public IEnumerator<T> GetEnumerator()
            => (this.Values_ForEnumerable as IEnumerable<T>).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
