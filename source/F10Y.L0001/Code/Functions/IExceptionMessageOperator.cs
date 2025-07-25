using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IExceptionMessageOperator :
        L0000.IExceptionMessageOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IExceptionMessageOperator _L0000 => L0000.ExceptionMessageOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Gets a message indicating the the input value of the <typeparamref name="TEnum"/> enumeration was unexpected.
        /// This is useful in producing an error in the default case for switch statements based on enumeration values.
        /// </summary>
        /// <remarks>
        /// See: https://stackoverflow.com/questions/13645149/what-is-the-correct-exception-to-throw-for-unhandled-enum-values
        /// </remarks>
        public string Get_UnexpectedEnumerationValueExceptionMessage<TEnum>(TEnum unexpectedValue)
            where TEnum : Enum
        {
            var output = $"Unexpected enumeration value: '{unexpectedValue}' for enumeration type {typeof(TEnum).FullName}";
            return output;
        }

        /// <summary>
        /// Given a value (and its type), get an exception message descrbing how the value of the type is unhandled.
        /// </summary>
        public string Get_UnhandledValueExceptionMessage<TValue>(TValue value)
        {
            var typeName = Instances.TypeOperator.Get_TypeName(value);

            var output = this.Get_UnhandledValueExceptionMessage(
                value,
                typeName);

            return output;
        }

        /// <summary>
        /// Given a value and its type name, get an exception message descrbing how the value of the type is unhandled.
        /// </summary>
        public string Get_UnhandledValueExceptionMessage<TValue>(
            TValue value,
            string typeName)
        {
            var valueName = value is null
                ? Instances.Texts.null_Standard
                : value.ToString()
                ;

            var message = $"Unhandled value:\n\t{valueName}: value\n\t{typeName}: type name";
            return message;
        }

        public string Get_UnrecognizedEnumerationValueExceptionMessage<TEnum>(string representation)
            where TEnum : Enum
        {
            var enumerationTypeName = Instances.TypeOperator.Get_TypeNameOf<TEnum>();

            var message = $"Unrecognized representation '{representation}' for enumeration type {enumerationTypeName}.";
            return message;
        }
    }
}
