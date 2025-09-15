using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IVersionOperator :
        L0000.IVersionOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IVersionOperator _L0000 => L0000.VersionOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public string Ensure_WithoutPrefixV(string versionString)
        {
            var has_PrefixV = this.Has_PrefixV(versionString);

            var output = has_PrefixV
                ? this.Make_WithoutPrefixV(versionString)
                : versionString
                ;

            return output;
        }

        public string Ensure_WithoutTrailingSlash(string versionString)
        {
            var hasTrailingSlash = this.Has_TrailingSlash(versionString);

            var output = hasTrailingSlash
                ? this.Make_WithoutTrailingSlash(versionString)
                : versionString
                ;

            return output;
        }

        /// <summary>
        /// Does the version string have a prefixed "v"?
        /// </summary>
        /// <remarks>
        /// Some version strings look like "v2.1".
        /// </remarks>
        /// <returns>
        /// <para>Null or empty strings return false.</para>
        /// </returns>
        public bool Has_PrefixV(string versionString)
        {
            var is_NullOrEmpty = Instances.StringOperator.Is_NullOrEmpty(versionString);
            if (is_NullOrEmpty)
            {
                return false;
            }

            var firstCharacter = Instances.StringOperator.Get_Character_First(versionString);

            var output = Instances.CharacterOperator.Are_Equal(
                firstCharacter,
                Instances.Characters.v);

            return output;
        }

        /// <summary>
        /// Does the version string have a trailing "/"?
        /// </summary>
        /// <remarks>
        /// Some version strings look like "v2.1/".
        /// </remarks>
        /// <returns>
        /// <para>Null or empty strings return false.</para>
        /// </returns>
        public bool Has_TrailingSlash(string versionString)
        {
            var is_NullOrEmpty = Instances.StringOperator.Is_NullOrEmpty(versionString);
            if (is_NullOrEmpty)
            {
                return false;
            }

            var lastCharacter = Instances.StringOperator.Get_Character_Last(versionString);

            var output = Instances.CharacterOperator.Are_Equal(
                lastCharacter,
                Instances.Characters.Slash);

            return output;
        }

        public string Make_WithoutPrefixV(string versionString)
        {
            var output = Instances.StringOperator.Except_First(versionString);
            return output;
        }

        public string Make_WithoutTrailingSlash(string versionString)
        {
            var output = Instances.StringOperator.Except_Last(versionString);
            return output;
        }

        /// <summary>
        /// Parses the version string.
        /// </summary>
        /// <remarks>
        /// Chooses <see cref="Parse_HandlingPrefixV_AndTrailingSlash(string)"/> as the default.
        /// </remarks>
        new Version Parse(string versionString)
            => this.Parse_HandlingPrefixV_AndTrailingSlash(versionString);

        /// <summary>
        /// Some version strings look like "v2.1/" (encountered in a .NET Standard 2.1 project's deps.json compilation output file).
        /// </summary>
        Version Parse_HandlingPrefixV_AndTrailingSlash(string versionString)
        {
            var versionString_EnsuredWithoutPrefixV = this.Ensure_WithoutPrefixV(versionString);
            var versionString_EnsuredWithoutPrefixV_OrTrailingSlash = this.Ensure_WithoutTrailingSlash(versionString_EnsuredWithoutPrefixV);

            var output = _L0000.Parse(versionString_EnsuredWithoutPrefixV_OrTrailingSlash);
            return output;
        }

        Version Parse_WithoutHandlingPrefixV_AndTrailingSlash(string versionString)
            => _L0000.Parse(versionString);
    }
}
