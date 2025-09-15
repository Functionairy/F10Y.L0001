using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IEnumerationOperator :
        L0000.IEnumerationOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IEnumerationOperator _L0000 => L0000.EnumerationOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IExceptionMessageOperator.Get_UnexpectedEnumerationValueExceptionMessage{TEnum}(TEnum)"/>
        public string Get_UnexpectedEnumerationValueExceptionMessage<TEnum>(TEnum unexpectedValue)
            where TEnum : Enum
        {
            var output = Instances.ExceptionMessageOperator.Get_UnexpectedEnumerationValueExceptionMessage(unexpectedValue);
            return output;
        }

        public Exception Get_UnexpectedEnumerationValueException<TEnum>(TEnum unexpectedValue)
            where TEnum : Enum
        {
            var output = Instances.ExceptionOperator.Get_UnexpectedEnumerationValueException(unexpectedValue);
            return output;
        }
    }
}
