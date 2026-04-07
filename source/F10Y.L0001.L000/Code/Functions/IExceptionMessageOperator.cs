using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IExceptionMessageOperator :
        L0000.IExceptionMessageOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IExceptionMessageOperator _L0000 => L0000.ExceptionMessageOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        string Get_UnrecognizedEnumerationValueExceptionMessage<TEnum>(string representation)
            where TEnum : Enum
        {
            var enumerationTypeName = Instances.TypeOperator.Get_TypeNameOf<TEnum>();

            var message = $"Unrecognized representation '{representation}' for enumeration type {enumerationTypeName}.";
            return message;
        }
    }
}
