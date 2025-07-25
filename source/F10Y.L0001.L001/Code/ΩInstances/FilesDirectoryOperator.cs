using System;


namespace F10Y.L0001.L001
{
    public class FilesDirectoryOperator : IFilesDirectoryOperator
    {
        #region Infrastructure

        public static IFilesDirectoryOperator Instance { get; } = new FilesDirectoryOperator();


        private FilesDirectoryOperator()
        {
        }

        #endregion
    }
}
