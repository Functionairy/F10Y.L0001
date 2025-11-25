using System;
using System.Text;


namespace F10Y.L0001.L000.Extensions
{
    public static class StringBuilderExtensions
    {
        public static string Get_String(this StringBuilder stringBuilder,
            Action<StringBuilder> modifier)
        {
            var output = Instances.StringOperator.Get_String(
                stringBuilder,
                modifier);

            return output;
        }
    }
}
