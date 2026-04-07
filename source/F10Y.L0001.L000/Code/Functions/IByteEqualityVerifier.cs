using System;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IByteEqualityVerifier
    {
        /// <summary>
        /// Byte-by-byte, verify that two byte arrays are equal.
        /// </summary>
        /// <remarks>
        /// This is useful in testing file byte-level equality.
        /// </remarks>
        void Verify_Equality(
            byte[] bytesA,
            byte[] bytesB)
        {
            var byteCountA = bytesA.Length;
            var byteCountB = bytesB.Length;

            var sameByteCount = byteCountA == byteCountB;
            if (!sameByteCount)
            {
                throw new Exception($"Differing byte counts: A is {byteCountA}, and B is {byteCountB}.");
            }

            for (int iByte = 0; iByte < bytesA.Length; iByte++)
            {
                var byteIsEqual = bytesA[iByte] == bytesB[iByte];
                if (!byteIsEqual)
                {
                    throw new Exception($"Byte number {iByte} was unequal.");
                }
            }
        }
    }
}
