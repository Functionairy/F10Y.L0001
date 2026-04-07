using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface ISwitchOperator :
        L000.ISwitchOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L000.ISwitchOperator _L000 => L000.SwitchOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IExceptionOperator.Get_DefaultCaseException_ForType{T}(T)"/>
        Exception Get_DefaultCaseException_ForType<T>(T value)
        {
            var output = Instances.ExceptionOperator.Get_DefaultCaseException_ForType(value);
            return output;
        }
    }
}
