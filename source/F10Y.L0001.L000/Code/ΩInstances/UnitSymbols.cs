using System;


namespace F10Y.L0001.L000
{
    public class UnitSymbols : IUnitSymbols
    {
        #region Infrastructure

        public static IUnitSymbols Instance { get; } = new UnitSymbols();


        private UnitSymbols()
        {
        }

        #endregion
    }
}


namespace F10Y.L0001.L000.Raw
{
    public class UnitSymbols : IUnitSymbols
    {
        #region Infrastructure

        public static IUnitSymbols Instance { get; } = new UnitSymbols();


        private UnitSymbols()
        {
        }

        #endregion
    }
}
