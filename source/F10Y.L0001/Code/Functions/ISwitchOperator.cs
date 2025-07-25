using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface ISwitchOperator :
        L0000.ISwitchOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.ISwitchOperator _L0000 => L0000.SwitchOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IExceptionOperator.Get_DefaultCaseException_ForType{T}(T)"/>
        public Exception Get_DefaultCaseException_ForType<T>(T value)
        {
            var output = Instances.ExceptionOperator.Get_DefaultCaseException_ForType(value);
            return output;
        }

        /// <inheritdoc cref="IEnumerationOperator.Get_UnexpectedEnumerationValueException{TEnum}(TEnum)"/>
        public Exception Get_UnexpectedEnumerationValueException<TEnum>(TEnum unexpectedValue)
            where TEnum : Enum
        {
            var output = Instances.EnumerationOperator.Get_UnexpectedEnumerationValueException(unexpectedValue);
            return output;
        }

        public Exception Get_UnrecognizedEnumerationValueException<TEnum>(string representation)
            where TEnum : Enum
        {
            var output = Instances.ExceptionOperator.Get_UnrecognizedEnumerationValueException<TEnum>(representation);
            return output;
        }
    }
}
