using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L004
{
    [FunctionsMarker]
    public partial interface IGuidOperator :
        L000.IGuidOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L000.IGuidOperator _L000 => L000.GuidOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Uses the seed <see cref="Z000.ISeeds.Default"/> (<inheritdoc cref="Z000.ISeeds.Default" path="descendant::value"/>).
        /// </summary>
        Guid New_Seeded()
            => this.New_Seeded(
                Instances.Seeds.Default);

        Guid New_Seeded(out Random random)
            => this.New_Seeded(
                Instances.Seeds.Default,
                out random);
    }
}
