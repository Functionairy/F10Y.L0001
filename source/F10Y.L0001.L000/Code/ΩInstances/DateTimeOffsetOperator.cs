using System;


namespace F10Y.L0001.L000
{
    public class DateTimeOffsetOperator : IDateTimeOffsetOperator
    {
        #region Infrastructure

        public static IDateTimeOffsetOperator Instance { get; } = new DateTimeOffsetOperator();


        private DateTimeOffsetOperator()
        {
        }

        #endregion
    }
}
