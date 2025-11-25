using System;
using System.Text;

using Instances = F10Y.L0001.X000.Instances;


namespace F10Y.Extensions
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
