using System;
using System.Reflection;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface ITypeOperations
    {
        Func<TypeInfo, bool> Where_TypeName_Short_Is(string typeName_Short)
            => typeInfo => Instances.TypeOperator.TypeName_Short_Is(
                typeInfo,
                typeName_Short);
    }
}
