using System;
using System.IO;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IDriveInfoOperator :
        L0000.IDriveInfoOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IDriveInfoOperator _L0000 => L0000.DriveInfoOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        double Get_FreeSpace_InGibibytes_AsDouble(DriveInfo drive)
        {
            var freeSpace = this.Get_FreeSpace(drive);

            var output = Instances.BytesOperator.Get_Gibibytes_AsDouble(freeSpace);
            return output;
        }

        double Get_Size_InGibibytes_AsDouble(DriveInfo drive)
        {
            var size = this.Get_Size(drive);

            var output = Instances.BytesOperator.Get_Gibibytes_AsDouble(size);
            return output;
        }
    }
}
