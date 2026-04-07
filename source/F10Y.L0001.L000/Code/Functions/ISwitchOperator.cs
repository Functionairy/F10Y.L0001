using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface ISwitchOperator :
        L0000.ISwitchOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.ISwitchOperator _L0000 => L0000.SwitchOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Exception Get_UnrecognizedEnumerationValueException<TEnum>(string representation)
            where TEnum : Enum
        {
            var output = Instances.ExceptionOperator.Get_UnrecognizedEnumerationValueException<TEnum>(representation);
            return output;
        }
    }
}
