using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Functionairy-opinioned directory separators.
    /// </remarks>
    [ValuesMarker]
    public partial interface IDirectorySeparators :
        L0000.IDirectorySeparators
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IDirectorySeparators _L0000 => L0000.DirectorySeparators.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// The standard directory separator for Functionairy is <see cref="L0000.IDirectorySeparators.Windows_AsCharacter"/>.
        /// </summary>
        public char Standard_AsCharacter => this.Windows_AsCharacter;

        /// <inheritdoc cref="Standard_AsCharacter"/>
        public char Standard => this.Standard_AsCharacter;
    }
}
