using System;

using F10Y.T0002;

using F10Y.L0001.T000;


namespace F10Y.L0001
{
    /// <summary>
    /// Operator for the <see cref="AnyOrAll"/> enumeration.
    /// </summary>
    [FunctionsMarker]
    public partial interface IAnyOrAllOperator
    {
        public T Switch<T>(
            AnyOrAll anyOrAll,
            T for_All,
            T for_Any)
        {
            var output = anyOrAll switch
            {
                AnyOrAll.All => for_All,
                AnyOrAll.Any => for_Any,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(anyOrAll)
            };

            return output;
        }

        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(AnyOrAll)" path="/remarks"/>
        public AnyOrAll From_String_Standard(string anyOrAll)
        {
            var output = anyOrAll switch
            {
                ITexts.ALL_Constant => AnyOrAll.All,
                ITexts.ANY_Constant => AnyOrAll.Any,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<AnyOrAll>(anyOrAll)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public AnyOrAll From_String(string anyOrAll)
        {
            var output = this.From_String_Standard(anyOrAll);
            return output;
        }

        /// <summary>
        /// Converts a visibility to its standard string representation.
        /// </summary>
        /// <remarks>
        /// The standard strings are:
        /// <list type="bullet">
        /// <item><inheritdoc cref="ITexts.ALL" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.ANY" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(AnyOrAll anyOrAll)
        {
            var output = this.Switch(
                anyOrAll,
                Instances.Texts.ALL,
                Instances.Texts.ANY);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(AnyOrAll)"/> as the default.
        /// </summary>
        public string To_String(AnyOrAll anyOrAll)
        {
            var output = this.To_String_Standard(anyOrAll);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out AnyOrAll anyOrAll)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.ALL_Constant:
                    anyOrAll = AnyOrAll.All;
                    break;

                case ITexts.ANY_Constant:
                    anyOrAll = AnyOrAll.Any;
                    break;

                default:
                    anyOrAll = default;
                    output = false;
                    break;
            }

            return output;
        }
    }
}
