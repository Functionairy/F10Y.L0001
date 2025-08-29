using System;
using System.Threading.Tasks;
using System.Xml.Linq;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IDocumentationXmlFileOperator
    {
        /// <summary>
        /// Loads the .NET documentation XML file as an <see cref="XDocument"/>.
        /// </summary>
        /// <remarks>
        /// Note that insignificant whitespace is preserved while loading the file (<see cref="LoadOptions.PreserveWhitespace"/>).
        /// This is done because whitespace is an essential part of many member documentations!
        /// <para>
        /// However, the structure of the documentation file itself adds extra indentation to each member documentation that must be subtracted out.
        /// </para>
        /// </remarks>
        public Task<XDocument> Load_AsDocument(string documentationXmlFilePath)
            => Instances.XDocumentOperator.Load(
                documentationXmlFilePath,
                // Need to preserve whitespace inside of documentation comments.
                LoadOptions.PreserveWhitespace);

        /// <summary>
        /// Loads the .NET documentation XML file as an <see cref="XElement"/>.
        /// </summary>
        /// <inheritdoc cref="Load_AsDocument(string)" path="/remarks"/>
        public async Task<XElement> Load_AsElement(string documentationXmlFilePath)
        {
            var document = await this.Load_AsDocument(documentationXmlFilePath);

            var output = Instances.DocumentationXmlOperator.Get_DocumentationElement(document);
            return output;
        }

        /// <inheritdoc cref="Load_AsElement(string)" path="/summary"/>
        /// <remarks>
        /// Chooses <see cref="Load_AsElement(string)"/> as the default.
        /// <para>
        /// <inheritdoc cref="Load_AsDocument(string)" path="/remarks"/>
        /// </para>
        /// </remarks>
        public Task<XElement> Load(string documentationXmlFilePath)
            => this.Load_AsElement(documentationXmlFilePath);
    }
}
