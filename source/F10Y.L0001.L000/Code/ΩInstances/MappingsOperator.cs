using System;


namespace F10Y.L0001.L000
{
    public class MappingsOperator : IMappingsOperator
    {
        #region Infrastructure

        public static IMappingsOperator Instance { get; } = new MappingsOperator();


        private MappingsOperator()
        {
        }

        #endregion
    }
}
