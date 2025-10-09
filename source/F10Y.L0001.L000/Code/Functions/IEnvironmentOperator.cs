using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IEnvironmentOperator :
        L0000.IEnvironmentOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IEnvironmentOperator _L0000 => L0000.EnvironmentOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Dictionary<string, string> Get_SpecialDirectoryPaths_BySpecialDirectory()
        {
            var specialDirectory_Values = Instances.EnumerationOperator.Get_Values<Environment.SpecialFolder>();

            var output = specialDirectory_Values
                .Distinct() /// There is a collision of multiple names-to-single value for <see cref="Environment.SpecialFolder.Personal"/> and <see cref="Environment.SpecialFolder.MyDocuments"/>.
                .ToDictionary(
                    Instances.EnumerationOperator.Get_StringRepresentation,
                    this.Get_SpecialDirectoryPath);

            return output;
        }
    }
}
