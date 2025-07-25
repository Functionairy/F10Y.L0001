using System;


namespace F10Y.L0001
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
