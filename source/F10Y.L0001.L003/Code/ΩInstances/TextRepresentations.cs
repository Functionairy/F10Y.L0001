using System;


namespace F10Y.L0001.L003
{
    public class TextRepresentations : ITextRepresentations
    {
        #region Infrastructure

        public static ITextRepresentations Instance { get; } = new TextRepresentations();


        private TextRepresentations()
        {
        }

        #endregion
    }
}


namespace F10Y.L0001.L003.Raw
{
    public class TextRepresentations : ITextRepresentations
    {
        #region Infrastructure

        public static ITextRepresentations Instance { get; } = new TextRepresentations();


        private TextRepresentations()
        {
        }

        #endregion
    }
}
