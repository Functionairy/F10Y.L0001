using System;
using System.Threading.Tasks;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IFileEqualityVerifier
    {
        /// <summary>
        /// Byte-by-byte, verify that two files are the same.
        /// </summary>
        async Task Verify_FileEquality_AtByteLevel(
            string filePathA,
            string filePathB)
        {
            var gettingBytesA = Instances.FileOperator.Read_AllBytes(filePathA);
            var gettingBytesB = Instances.FileOperator.Read_AllBytes(filePathB);

            await Task.WhenAll(
                gettingBytesA,
                gettingBytesB);

            var bytesA = await gettingBytesA;
            var bytesB = await gettingBytesB;

            Instances.ByteEqualityVerifier.Verify_Equality(
                bytesA,
                bytesB);
        }

        /// <inheritdoc cref="Verify_FileEquality_AtByteLevel(string, string)"/>
        void Verify_FileEquality_AtByteLevel_Synchonous(
            string filePathA,
            string filePathB)
        {
            var bytesA = Instances.FileOperator.Read_AllBytes_Synchronous(filePathA);
            var bytesB = Instances.FileOperator.Read_AllBytes_Synchronous(filePathB);

            Instances.ByteEqualityVerifier.Verify_Equality(
                bytesA,
                bytesB);
        }
    }
}
