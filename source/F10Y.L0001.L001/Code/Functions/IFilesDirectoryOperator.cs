using System;

using F10Y.T0002;


namespace F10Y.L0001.L001
{
    [FunctionsMarker]
    public partial interface IFilesDirectoryOperator
    {
        /// <summary>
        /// Gets a directory path of the form: {Executable Directory Path}/Files/
        /// <para>Uses the canonical files directory name "<inheritdoc cref="IDirectoryNames.Files" path="descendant::value"/>". (<see cref="IDirectoryNames.Files"/>)</para>
        /// </summary>
        string Get_FilesDirectoryPath_FromExecutableDirectoryPath(string executableDirectoryPath)
        {
            var output = Instances.PathOperator.Get_DirectoryPath(
                executableDirectoryPath,
                Instances.DirectoryNames.Files);

            return output;
        }

        /// <summary>
        /// Gets a directory path of the form: {Executable Directory Path}/Files/
        /// </summary>
        string Get_FilesDirectoryPath()
        {
            var executableDirectoryPath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryPath();

            var output = this.Get_FilesDirectoryPath_FromExecutableDirectoryPath(executableDirectoryPath);
            return output;
        }

        /// <summary>
        /// Gets a directory path of the form: {Files Directory Path}/{Project Name}/
        /// </summary>
        string Get_ProjectSpecificFilesDirectoryPath(
            string filesDirectoryPath,
            string projectName)
        {
            var output = Instances.PathOperator.Get_DirectoryPath(
                filesDirectoryPath,
                projectName);

            return output;
        }

        /// <summary>
        /// Gets a directory path of the form: {Executable Directory Path}/Files/{Project Name}/
        /// </summary>
        string Get_ProjectSpecificFilesDirectoryPath(string projectName)
        {
            var projectDirectoryName = Instances.DirectoryNameOperator.Ensure_IsValid(projectName);

            var filesDirectoryPath = this.Get_FilesDirectoryPath();

            var output = this.Get_ProjectSpecificFilesDirectoryPath(
                filesDirectoryPath,
                projectDirectoryName);

            return output;
        }

        /// <summary>
        /// Gets a path of the form: {Executable Directory Path}/Files/{Project Name}/{path}.
        /// </summary>
        string Get_Path_FromFilesDirectoryRelativePath(
            string projectName,
            string path_FilesProjectDirectoryRelative)
        {
            var projectSpecificFilesDirectoryPath = this.Get_ProjectSpecificFilesDirectoryPath(projectName);

            var output = Instances.PathOperator.Get_Path(
                projectSpecificFilesDirectoryPath,
                path_FilesProjectDirectoryRelative);

            return output;
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="Get_Path_FromFilesDirectoryRelativePath(string, string)"/>.
        /// </summary>
        string Get_Path(
            string projectName,
            string path_FilesProjectDirectoryRelative)
            => this.Get_Path_FromFilesDirectoryRelativePath(
                projectName,
                path_FilesProjectDirectoryRelative);
    }
}
