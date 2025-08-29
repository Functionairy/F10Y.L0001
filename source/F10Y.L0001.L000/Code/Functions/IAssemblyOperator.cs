using System;
using System.Reflection;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IAssemblyOperator :
        L0000.IAssemblyOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IAssemblyOperator _L0000 => L0000.AssemblyOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public string Get_DocumentationFilePath_ForAssembly(Assembly assembly)
        {
            var assemblyFilePath = this.Get_FilePath(assembly);

            var output = this.Get_DocumentationFilePath_ForAssemblyFilePath(assemblyFilePath);
            return output;
        }

        /// <inheritdoc cref="IDocumentationFileOperator.Get_DocumentationFilePath_ForAssemblyFilePath(string)"/>
        public string Get_DocumentationFilePath_ForAssemblyFilePath(string assemblyFilePath)
            => Instances.DocumentationFileOperator.Get_DocumentationFilePath_ForAssemblyFilePath(assemblyFilePath);
    }
}
