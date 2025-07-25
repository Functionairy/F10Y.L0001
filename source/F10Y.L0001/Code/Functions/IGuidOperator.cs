using System;

using F10Y.T0002;
using F10Y.T0011;

using GuidDocumentation = F10Y.Y0000.Documentation.For_Guid;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IGuidOperator :
        L0000.IGuidOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IGuidOperator _F10Y_L0000 => L0000.GuidOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Uses the seed <see cref="Z000.ISeeds.Default"/> (<inheritdoc cref="Z000.ISeeds.Default" path="descendant::value"/>).
        /// </summary>
        public Guid New_Seeded()
            => this.New_Seeded(
                Instances.Seeds.Default);

        /// <summary>
        /// <para>The standard format is default (D uppercase) format.</para>
        /// <inheritdoc cref="GuidDocumentation.D_Uppercase_Format"/>
        /// </summary>
        public string To_String_Standard(Guid guid)
        {
            var output = this.To_String_D_Uppercase_Format(guid);
            return output;
        }
    }
}
