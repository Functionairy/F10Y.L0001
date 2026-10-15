using System;


namespace F10Y.L0001.L000
{
#pragma warning disable IDE1006 // Naming Styles
    public interface Instances :
#pragma warning restore IDE1006 // Naming Styles
        Instances_Internal,
        L0000.Instances_Internal
    {
        public static IByteEqualityVerifier ByteEqualityVerifier => L000.ByteEqualityVerifier.Instance;
        public static IDateTimeFormats DateTimeFormats => L000.DateTimeFormats.Instance;
        public static IDateTimeFormatTemplates DateTimeFormatTemplates => L000.DateTimeFormatTemplates.Instance;
        public static new IDirectoryInfoOperator DirectoryInfoOperator => L000.DirectoryInfoOperator.Instance;
        public static IDocumentationFileOperator DocumentationFileOperator => L000.DocumentationFileOperator.Instance;
        public static IDocumentationXmlFileOperator DocumentationXmlFileOperator => L000.DocumentationXmlFileOperator.Instance;
        public static IDocumentationXmlNodeNames DocumentationXmlNodeNames => L000.DocumentationXmlNodeNames.Instance;
        public static IDocumentationXmlOperator DocumentationXmlOperator => L000.DocumentationXmlOperator.Instance;
        public static new IEnumerableOperator EnumerableOperator => L000.EnumerableOperator.Instance;
        public static IExceptionMessageOperator ExceptionMessageOperator => L000.ExceptionMessageOperator.Instance;
        public static new IExceptionOperator ExceptionOperator => L000.ExceptionOperator.Instance;
        public static new IFileExtensions FileExtensions => L000.FileExtensions.Instance;
        public static IFormats Formats => L000.Formats.Instance;
        public static new IFormatTemplates FormatTemplates => L000.FormatTemplates.Instance;
        public static new IStringOperator StringOperator => L000.StringOperator.Instance;
        public static new IStrings Strings => L000.Strings.Instance;
        public static ISwitchOperator SwitchOperator => L000.SwitchOperator.Instance;
        public static ITexts Texts => L000.Texts.Instance;
        public static ITypeOperator TypeOperator => L000.TypeOperator.Instance;
        public static new IValues Values => L000.Values.Instance;
        public static new IVersionOperator VersionOperator => L000.VersionOperator.Instance;
        public static IXDocumentOperator XDocumentOperator => L000.XDocumentOperator.Instance;
    }


#pragma warning disable IDE1006 // Naming Styles
    public interface Instances_Internal
#pragma warning restore IDE1006 // Naming Styles
    {
        public static IBytesOperator BytesOperator => L000.BytesOperator.Instance;
        public static IFormatTemplates FormatTemplates => L000.FormatTemplates.Instance;
        public static ITimingOperator TimingOperator => L000.TimingOperator.Instance;
        public static IUnitSymbols UnitSymbols => L000.UnitSymbols.Instance;
        public static IVersionOperator VersionOperator => L000.VersionOperator.Instance;
    }
}