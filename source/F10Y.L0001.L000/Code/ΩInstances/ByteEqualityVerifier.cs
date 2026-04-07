using System;


namespace F10Y.L0001.L000
{
    public class ByteEqualityVerifier : IByteEqualityVerifier
    {
        #region Infrastructure

        public static IByteEqualityVerifier Instance { get; } = new ByteEqualityVerifier();


        private ByteEqualityVerifier()
        {
        }

        #endregion
    }
}
