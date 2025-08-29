using System;
using System.Threading.Tasks;
using System.Xml.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IXDocumentOperator :
        L0000.IXDocumentOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IXDocumentOperator _L0000 => L0000.XDocumentOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public async Task<XDocument> Load(
            string filePath,
            LoadOptions loadOptions)
        {
            using var fileStream = Instances.FileStreamOperator.Open_Read(filePath);

            var xDocument = await XDocument.LoadAsync(
                fileStream,
                loadOptions,
                Instances.CancellationTokens.None);

            return xDocument;
        }
    }
}
