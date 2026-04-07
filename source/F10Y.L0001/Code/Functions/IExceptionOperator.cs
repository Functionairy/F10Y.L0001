using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IExceptionOperator :
        L000.IExceptionOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L000.IExceptionOperator _L000 => L000.ExceptionOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IExceptionMessageOperator.Get_UnhandledValueExceptionMessage{TValue}(TValue, string)"/>
        Exception Get_DefaultCaseException_ForType<T>(T value)
        {
            var message = Instances.ExceptionMessageOperator.Get_UnhandledValueExceptionMessage(value);

            var output = this.From(message);
            return output;
        }

        string Get_Text(Exception exception)
            => exception.ToString();

        Exception Get_UnexpectedEnumerationValueException<TEnum>(TEnum unexpectedValue)
            where TEnum : Enum
        {
            var message = Instances.ExceptionMessageOperator.Get_UnexpectedEnumerationValueExceptionMessage(unexpectedValue);

            var output = this.From(message);
            return output;
        }
    }
}
