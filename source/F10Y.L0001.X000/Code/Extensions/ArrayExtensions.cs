using System;

using Instances = F10Y.L0001.X000.Instances;


namespace System.Linq
{
    public static class ArrayExtensions
    {
        public static T[] Empty_IfNull<T>(this T[] array)
            => Instances.ArrayOperator.Empty_IfNull(array);

        public static int Get_IndexOfLast(this Array array)
            => Instances.ArrayOperator.Get_IndexOfLast(array);

        public static T[] Null_IfEmpty<T>(this T[] array)
            => Instances.ArrayOperator.Null_IfEmpty(array);
    }
}
