using System;


namespace F10Y.L0001.L000
{
    public class BytesOperator : IBytesOperator
    {
        #region Infrastructure

        public static IBytesOperator Instance { get; } = new BytesOperator();


        private BytesOperator()
        {
        }

        #endregion
    }
}
