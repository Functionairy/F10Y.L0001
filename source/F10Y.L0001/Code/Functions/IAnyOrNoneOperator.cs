using System;

using F10Y.T0002;

using F10Y.L0001.T000;


namespace F10Y.L0001
{
    /// <summary>
    /// Operator for the <see cref="AnyOrNone"/> enumeration.
    /// </summary>
    [FunctionsMarker]
    public partial interface IAnyOrNoneOperator
    {
        public T Switch<T>(
            AnyOrNone anyOrNone,
            T for_All,
            T for_None)
        {
            var output = anyOrNone switch
            {
                AnyOrNone.Any => for_All,
                AnyOrNone.None => for_None,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(anyOrNone)
            };

            return output;
        }

        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(AnyOrNone)" path="/remarks"/>
        public AnyOrNone From_String_Standard(string anyOrNone)
        {
            var output = anyOrNone switch
            {
                ITexts.ANY_Constant => AnyOrNone.Any,
                ITexts.NONE_Constant => AnyOrNone.None,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<AnyOrNone>(anyOrNone)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public AnyOrNone From_String(string anyOrNone)
        {
            var output = this.From_String_Standard(anyOrNone);
            return output;
        }

        /// <summary>
        /// Converts a visibility to its standard string representation.
        /// </summary>
        /// <remarks>
        /// The standard strings are:
        /// <list type="bullet">
        /// <item><inheritdoc cref="ITexts.ANY" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.NONE" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(AnyOrNone anyOrNone)
        {
            var output = this.Switch(
                anyOrNone,
                Instances.Texts.ANY,
                Instances.Texts.NONE);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(AnyOrNone)"/> as the default.
        /// </summary>
        public string To_String(AnyOrNone anyOrNone)
        {
            var output = this.To_String_Standard(anyOrNone);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out AnyOrNone anyOrNone)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.ANY_Constant:
                    anyOrNone = AnyOrNone.Any;
                    break;

                case ITexts.NONE_Constant:
                    anyOrNone = AnyOrNone.None;
                    break;

                default:
                    anyOrNone = default;
                    output = false;
                    break;
            }

            return output;
        }
    }
}
