using System;

using F10Y.T0002;
using F10Y.T0011;

using GuidDocumentation = F10Y.Y0000.Documentation.For_Guid;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IGuidOperator :
        L0000.IGuidOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IGuidOperator _L0000 => L0000.GuidOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para>The standard format is default (D uppercase) format.</para>
        /// <inheritdoc cref="GuidDocumentation.D_Uppercase_Format"/>
        /// </summary>
        string To_String_Standard(Guid guid)
        {
            var output = this.To_String_D_Uppercase_Format(guid);
            return output;
        }
    }
}
