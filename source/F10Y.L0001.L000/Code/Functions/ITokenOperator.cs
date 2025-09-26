using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface ITokenOperator
    {
        string Combine(
            string tokenSeparator,
            params string[] tokens)
            => Instances.StringOperator.Join(
                tokenSeparator,
                tokens);

        string Combine(
            string tokenSeparator,
            IEnumerable<string> tokens)
            => Instances.StringOperator.Join(
                tokenSeparator,
                tokens);

        string Remove_LastToken(
            string value,
            string tokenSeparator)
        {
            var indexOfLast = Instances.StringOperator.Get_LastIndexOf(
                tokenSeparator,
                value);

            var output = Instances.StringOperator.Get_Substring_Upto_Exclusive(
                indexOfLast,
                value);

            return output;
        }
    }
}
