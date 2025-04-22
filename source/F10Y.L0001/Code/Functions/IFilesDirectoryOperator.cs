using System;

using F10Y.T0002;


namespace F10Y.L0001
{
    /// <summary>
    /// Functions for working with the Files output directory, containing files copied to an output directory.
    /// </summary>
    /// <remarks>
    /// Related prior work: R5T.F0091.
    /// </remarks>
    [FunctionsMarker]
    public partial interface IFilesDirectoryOperator
    {
        public string Get_FilesDirectoryPath_FromExecutableDirectoryPath(string executableDirectoryPath)
        {
            var output = Instances.PathOperator.Get_DirectoryPath(
                executableDirectoryPath,
                Instances.DirectoryNames.Files);

            return output;
        }

        public string Get_FilesDirectoryPath()
        {
            var executableDirectoryPath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryPath();

            var output = this.Get_FilesDirectoryPath_FromExecutableDirectoryPath(executableDirectoryPath);
            return output;
        }

        public string Get_ProjectSpecificFilesDirectoryPath(
            string filesDirectoryPath,
            string projectName)
        {
            var output = Instances.PathOperator.Get_DirectoryPath(
                filesDirectoryPath,
                projectName);

            return output;
        }

        public string Get_ProjectSpecificFilesDirectoryPath(string projectName)
        {
            var projectDirectoryName = Instances.DirectoryNameOperator.Ensure_IsValid(projectName);

            var filesDirectoryPath = this.Get_FilesDirectoryPath();

            var output = this.Get_ProjectSpecificFilesDirectoryPath(
                filesDirectoryPath,
                projectDirectoryName);

            return output;
        }

        public string Get_Path_FromFilesDirectoryRelativePath(
            string projectName,
            string path_FilesDirectoryRelative)
        {
            var projectSpecificFilesDirectoryPath = this.Get_ProjectSpecificFilesDirectoryPath(projectName);

            var output = Instances.PathOperator.Get_Path(
                projectSpecificFilesDirectoryPath,
                path_FilesDirectoryRelative);

            return output;
        }
    }
}
