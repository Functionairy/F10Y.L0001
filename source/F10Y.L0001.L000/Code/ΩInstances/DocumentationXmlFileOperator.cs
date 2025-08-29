using System;


namespace F10Y.L0001.L000
{
    public class DocumentationXmlFileOperator : IDocumentationXmlFileOperator
    {
        #region Infrastructure

        public static IDocumentationXmlFileOperator Instance { get; } = new DocumentationXmlFileOperator();


        private DocumentationXmlFileOperator()
        {
        }

        #endregion
    }
}
