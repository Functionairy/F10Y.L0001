using System;


namespace F10Y.L0001.L000
{
    public class DocumentationFileOperator : IDocumentationFileOperator
    {
        #region Infrastructure

        public static IDocumentationFileOperator Instance { get; } = new DocumentationFileOperator();


        private DocumentationFileOperator()
        {
        }

        #endregion
    }
}
