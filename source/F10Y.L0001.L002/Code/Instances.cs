using System;


namespace F10Y.L0001.L002
{
    public static class Instances
    {
        public static IBooleans Booleans => L002.Booleans.Instance;
        public static L0000.IDefaultOperator DefaultOperator => L0000.DefaultOperator.Instance;
        public static L0000.IExceptions Exceptions => L0000.Exceptions.Instance;
    }
}