using System;


namespace F10Y.L0001.L000
{
    public class AssemblyOperator : IAssemblyOperator
    {
        #region Infrastructure

        public static IAssemblyOperator Instance { get; } = new AssemblyOperator();


        private AssemblyOperator()
        {
        }

        #endregion
    }
}
