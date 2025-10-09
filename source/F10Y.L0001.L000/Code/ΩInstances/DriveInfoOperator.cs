using System;


namespace F10Y.L0001.L000
{
    public class DriveInfoOperator : IDriveInfoOperator
    {
        #region Infrastructure

        public static IDriveInfoOperator Instance { get; } = new DriveInfoOperator();


        private DriveInfoOperator()
        {
        }

        #endregion
    }
}
