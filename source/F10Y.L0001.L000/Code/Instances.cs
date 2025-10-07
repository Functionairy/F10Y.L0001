using System;


namespace F10Y.L0001.L000
{
    public static class Instances
    {
        public static L0000.IAssemblyOperator AssemblyOperator => L0000.AssemblyOperator.Instance;
        public static L0000.ICancellationTokens CancellationTokens => L0000.CancellationTokens.Instance;
        public static L0000.ICharacterOperator CharacterOperator => L0000.CharacterOperator.Instance;
        public static L0000.ICharacters Characters => L0000.Characters.Instance;
        public static L0000.IComparerOperator ComparerOperator => L0000.ComparerOperator.Instance;
        public static L0000.IConverter Converter => L0000.Converter.Instance;
        public static IDateTimeFormats DateTimeFormats => L000.DateTimeFormats.Instance;
        public static IDateTimeFormatTemplates DateTimeFormatTemplates => L000.DateTimeFormatTemplates.Instance;
        public static IDocumentationFileOperator DocumentationFileOperator => L000.DocumentationFileOperator.Instance;
        public static IDocumentationXmlFileOperator DocumentationXmlFileOperator => L000.DocumentationXmlFileOperator.Instance;
        public static IDocumentationXmlNodeNames DocumentationXmlNodeNames => L000.DocumentationXmlNodeNames.Instance;
        public static IDocumentationXmlOperator DocumentationXmlOperator => L000.DocumentationXmlOperator.Instance;
        public static IEnumerableOperator EnumerableOperator => L000.EnumerableOperator.Instance;
        public static IFileExtensions FileExtensions => L000.FileExtensions.Instance;
        public static L0000.IFileNameOperator FileNameOperator => L0000.FileNameOperator.Instance;
        public static L0000.IFileStreamOperator FileStreamOperator => L0000.FileStreamOperator.Instance;
        public static L0000.IFileSystemOperator FileSystemOperator => L0000.FileSystemOperator.Instance;
        public static IFormats Formats => L000.Formats.Instance;
        public static IFormatTemplates FormatTemplates => L000.FormatTemplates.Instance;
        public static L0000.IIndices Indices => L0000.Indices.Instance;
        public static L0000.IPathOperator PathOperator => L0000.PathOperator.Instance;
        public static IStringOperator StringOperator => L000.StringOperator.Instance;
        public static IStrings Strings => L000.Strings.Instance;
        public static ITexts Texts => L000.Texts.Instance;
        public static ITypeOperator TypeOperator => L000.TypeOperator.Instance;
        public static IValues Values => L000.Values.Instance;
        public static IXDocumentOperator XDocumentOperator => L000.XDocumentOperator.Instance;
        public static L0000.IXElementOperator XElementOperator => L0000.XElementOperator.Instance;
    }
}