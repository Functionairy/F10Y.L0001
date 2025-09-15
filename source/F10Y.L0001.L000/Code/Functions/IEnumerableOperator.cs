using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IEnumerableOperator :
        L0000.IEnumerableOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IEnumerableOperator _L0000 => L0000.EnumerableOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public IEnumerable<IEnumerable<T>> OrderBy_First<T>(IEnumerable<IEnumerable<T>> values)
        {
            var valuesAndFirst = values
                .Select(x => (First: x.FirstOrDefault(), Values: x))
                .OrderBy(x => x.First)
                .Select(x => x.Values)
                ;

            return valuesAndFirst;
        }

        public IEnumerable<T> Separate<T>(
            IEnumerable<T> enumerable,
            T separator)
        {
            var enumerator = enumerable.GetEnumerator();

            enumerator.MoveNext();

            var value = enumerator.Current;

            while (enumerator.MoveNext())
            {
                yield return value;

                yield return separator;

                value = enumerator.Current;
            }

            yield return value;
        }

        public IEnumerable<T> Separate_Many<T>(
            IEnumerable<IEnumerable<T>> enumerable,
            T separator)
        {
            var enumerator = enumerable.GetEnumerator();

            var any = enumerator.MoveNext();
            if (any)
            {
                var value = enumerator.Current;

                while (enumerator.MoveNext())
                {
                    foreach (var item in value)
                    {
                        yield return item;
                    }

                    yield return separator;

                    value = enumerator.Current;
                }

                foreach (var item in value)
                {
                    yield return item;
                }
            }
            else
            {
                yield break;
            }
        }

        public IEnumerable<TResult> Separate_Many<TSource, TResult>(
            IEnumerable<TSource> enumerable,
            Func<TSource, IEnumerable<TResult>> selector,
            TResult separator)
        {
            var enumerator = enumerable.GetEnumerator();

            var any = enumerator.MoveNext();
            if (any)
            {
                var value = enumerator.Current;

                var output = selector(value);

                while (enumerator.MoveNext())
                {
                    foreach (var item in output)
                    {
                        yield return item;
                    }

                    yield return separator;

                    value = enumerator.Current;

                    output = selector(value);
                }

                foreach (var item in output)
                {
                    yield return item;
                }
            }
            else
            {
                yield break;
            }
        }
    }
}
