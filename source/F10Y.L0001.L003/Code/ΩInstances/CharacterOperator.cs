using System;


namespace F10Y.L0001.L003
{
    public class CharacterOperator : ICharacterOperator
    {
        #region Infrastructure

        public static ICharacterOperator Instance { get; } = new CharacterOperator();


        private CharacterOperator()
        {
        }

        #endregion
    }
}
