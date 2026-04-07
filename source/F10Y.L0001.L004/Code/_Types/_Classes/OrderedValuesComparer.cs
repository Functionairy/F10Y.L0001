using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0001.L004
{
    /// <summary>
    /// Orders values based on a preset order of values.
    /// </summary>
    /// <remarks>
    /// Handles values that are not in the initial list by placing them at the end of the list,
    /// with their order unchanged.
    /// </remarks>
    [UtilityTypeMarker]
    public class OrderedValuesComparer<T> :
        IComparer<T>
    {
        private Dictionary<T, int> Indices_ByValue { get; }


        public OrderedValuesComparer(
            IList<T> values,
            IEqualityComparer<T> equalityComparer)
        {
            this.Indices_ByValue = Instances.DictionaryOperator.New<T, int>(equalityComparer);

            var index = 0;

            foreach (var value in values)
            {
                var alreadyAdded = Instances.DictionaryOperator.Contains_Key(
                    this.Indices_ByValue,
                    value);

                if(!alreadyAdded)
                {
                    this.Indices_ByValue.Add(
                        value,
                        index++);
                }
            }
        }

        public OrderedValuesComparer(IList<T> values)
            : this(
                  values,
                  Instances.EqualityComparers.For<T>().Default)
        {
            // Do nothing.
        }

        public int Compare(T x, T y)
        {
            var x_WasFound = Instances.DictionaryOperator.Has_Value(
                x,
                this.Indices_ByValue,
                out var index_OfX_OrDefault);

            var y_WasFound = Instances.DictionaryOperator.Has_Value(
                x,
                this.Indices_ByValue,
                out var index_OfY_OrDefault);

            if (x_WasFound)
            {
                if (y_WasFound)
                {
                    return index_OfX_OrDefault.CompareTo(index_OfY_OrDefault);
                }
                else
                {
                    return Instances.ComparisonResults.GreaterThan;
                }
            }
            else
            {
                if (y_WasFound)
                {
                    return Instances.ComparisonResults.LessThan;
                }
                else
                {
                    return Instances.ComparisonResults.EqualTo;
                }
            }
        }
    }
}
