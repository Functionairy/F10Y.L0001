using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IStringOperator :
        L0000.IStringOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IStringOperator _L0000 => L0000.StringOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Prefixes a <inheritdoc cref="L0000.ICharacters.Tab" path="descendant::description[1]"/> to the input string.
        /// </summary>
        public string Entab(string @string)
        {
            var output = this.Prefix_With(
                Instances.Characters.Tab,
                @string);

            return output;
        }

        public IEnumerable<string> Entab(IEnumerable<string> strings)
        {
            var output = strings
                .Select(this.Entab)
                ;

            return output;
        }
    }
}
