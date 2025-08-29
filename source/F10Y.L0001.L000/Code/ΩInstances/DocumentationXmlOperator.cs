using System;


namespace F10Y.L0001.L000
{
    public class DocumentationXmlOperator : IDocumentationXmlOperator
    {
        #region Infrastructure

        public static IDocumentationXmlOperator Instance { get; } = new DocumentationXmlOperator();


        private DocumentationXmlOperator()
        {
        }

        #endregion
    }
}
