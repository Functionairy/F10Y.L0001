using System;
using System.Collections.Generic;

using F10Y.L0000.Extensions;
using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IDocumentationFileOperator
    {
        /// <summary>
        /// Get all XML documentation files in the executable directory assuming all XML files are documentation files.
        /// </summary>
        IEnumerable<string> Enumerate_DocumentationFilePaths_AssumeAllXmls(
            string directoryPath)
        {
            return Instances.FileSystemOperator.Enumerate_XmlFiles(directoryPath);
        }

        /// <inheritdoc cref="Enumerate_DocumentationFilePaths_AssumeAllXmls(string)" path="/summary"/>
        /// <remarks>
        /// Chooses <see cref="Enumerate_DocumentationFilePaths_AssumeAllXmls(string)"/> as the default.
        /// </remarks>
        IEnumerable<string> Enumerate_DocumentationFilePaths(
            string directoryPath)
            => this.Enumerate_DocumentationFilePaths_AssumeAllXmls(directoryPath);

        string Get_AssemblyDocumentationFileName_FromAssemblyFileName(string assemblyFileName)
        {
            var assemblyName = Instances.AssemblyOperator.Get_AssemblyName_FromFileName(assemblyFileName);

            var output = this.Get_AssemblyDocumentationFileName_FromAssemblyName(assemblyName);
            return output;
        }

        /// <summary>
        /// Returns the XML documentation file name given the assembly name.
        /// </summary>
        string Get_AssemblyDocumentationFileName_FromAssemblyName(string assemblyName)
        {
            // Just append the "xml" file extension to the assembly name.
            var assemblyFileNameStem = Instances.AssemblyOperator.Get_AssemblyFileNameStem(assemblyName);

            var assemblyDocumentationFileName = Instances.FileNameOperator.Get_FileName(
                assemblyFileNameStem,
                Instances.FileExtensions.xml);

            return assemblyDocumentationFileName;
        }

        /// <summary>
        /// Get documentation files.
        /// </summary>
        string[] Get_DocumentationFilePaths_AssumeAllXmls(
            string directoryPath)
            => this.Enumerate_DocumentationFilePaths_AssumeAllXmls(directoryPath)
                .Now();

        /// <inheritdoc cref="Get_DocumentationFilePaths_AssumeAllXmls(string)" path="/summary"/>
        /// <remarks>
        /// Chooses <see cref="Get_DocumentationFilePaths_AssumeAllXmls(string)"/> as the default.
        /// </remarks>
        string[] Get_DocumentationFilePaths(
            string directoryPath)
            => Get_DocumentationFilePaths_AssumeAllXmls(directoryPath);

        string Get_DocumentationFilePath_ForAssemblyFilePath(string assemblyFilePath)
        {
            var assemblyFileName = Instances.PathOperator.Get_FileName(assemblyFilePath);
            var assemblyDirectoryPath = Instances.PathOperator.Get_ParentDirectoryPath_ForFile(assemblyFilePath);

            var documentationFileName = this.Get_AssemblyDocumentationFileName_FromAssemblyFileName(
                assemblyFileName);

            var documentationFilePath = Instances.PathOperator.Get_Path(
                assemblyDirectoryPath,
                documentationFileName);

            return documentationFilePath;
        }
    }
}
