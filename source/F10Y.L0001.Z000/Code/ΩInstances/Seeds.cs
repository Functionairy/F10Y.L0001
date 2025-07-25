using System;


namespace F10Y.L0001.Z000
{
    public class Seeds : ISeeds
    {
        #region Infrastructure

        public static ISeeds Instance { get; } = new Seeds();


        private Seeds()
        {
        }

        #endregion
    }
}
