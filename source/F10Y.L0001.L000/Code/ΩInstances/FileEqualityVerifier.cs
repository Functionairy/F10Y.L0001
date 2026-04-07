using System;


namespace F10Y.L0001.L000
{
    public class FileEqualityVerifier : IFileEqualityVerifier
    {
        #region Infrastructure

        public static IFileEqualityVerifier Instance { get; } = new FileEqualityVerifier();


        private FileEqualityVerifier()
        {
        }

        #endregion
    }
}
