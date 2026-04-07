using System;


namespace F10Y.L0001.L000
{
    public class TypeOperations : ITypeOperations
    {
        #region Infrastructure

        public static ITypeOperations Instance { get; } = new TypeOperations();


        private TypeOperations()
        {
        }

        #endregion
    }
}
