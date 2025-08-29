using System;


namespace F10Y.L0001.L000
{
    public class DocumentationXmlNodeNames : IDocumentationXmlNodeNames
    {
        #region Infrastructure

        public static IDocumentationXmlNodeNames Instance { get; } = new DocumentationXmlNodeNames();


        private DocumentationXmlNodeNames()
        {
        }

        #endregion
    }
}
