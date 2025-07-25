using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IRandomOperator :
        L0000.IRandomOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IRandomOperator _L0000 => L0000.RandomOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Uses the <see cref="Z000.ISeeds.Default"/> value. (<inheritdoc cref="Z000.ISeeds.Default" path="descendant::description"/>)
        /// </summary>
        public Random New_WithSeed_Default()
        {
            var output = this.New_WithSeed(Instances.Seeds.Default);
            return output;
        }

        /// <summary>
        /// Adds the given offset the <see cref="Z000.ISeeds.Default"/> value. (Which is <inheritdoc cref="Z000.ISeeds.Default" path="descendant::description"/>)
        /// </summary>
        public Random New_WithSeed_Default(int offset)
        {
            var seed = Instances.Seeds.Default + offset;

            var output = this.New_WithSeed(seed);
            return output;
        }
    }
}
