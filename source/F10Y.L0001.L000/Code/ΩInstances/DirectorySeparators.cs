using System;


namespace F10Y.L0001.L000
{
    public class DirectorySeparators : IDirectorySeparators
    {
        #region Infrastructure

        public static IDirectorySeparators Instance { get; } = new DirectorySeparators();


        private DirectorySeparators()
        {
        }

        #endregion
    }
}
