using System;

using F10Y.T0002;

using F10Y.L0001.T000;


namespace F10Y.L0001
{
    /// <summary>
    /// Operator for the <see cref="Inclusiveness"/> enumeration.
    /// </summary>
    [FunctionsMarker]
    public partial interface IInclusivenessOperator
    {
        public T Switch<T>(
            Inclusiveness contiguity,
            T for_Exclusive,
            T for_Inclusive)
        {
            var output = contiguity switch
            {
                Inclusiveness.Exclusive => for_Exclusive,
                Inclusiveness.Inclusive => for_Inclusive,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(contiguity)
            };

            return output;
        }

        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(Inclusiveness)" path="/remarks"/>
        public Inclusiveness From_String_Standard(string contiguity)
        {
            var output = contiguity switch
            {
                ITexts.Exclusive_Constant => Inclusiveness.Exclusive,
                ITexts.Inclusive_Constant => Inclusiveness.Inclusive,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<Inclusiveness>(contiguity)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public Inclusiveness From_String(string contiguity)
        {
            var output = this.From_String_Standard(contiguity);
            return output;
        }

        /// <summary>
        /// Converts a visibility to its standard string representation.
        /// </summary>
        /// <remarks>
        /// The standard strings are:
        /// <list type="bullet">
        /// <item><inheritdoc cref="ITexts.Exclusive" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.Inclusive" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(Inclusiveness contiguity)
        {
            var output = this.Switch(
                contiguity,
                Instances.Texts.Exclusive,
                Instances.Texts.Inclusive);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(Inclusiveness)"/> as the default.
        /// </summary>
        public string To_String(Inclusiveness contiguity)
        {
            var output = this.To_String_Standard(contiguity);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out Inclusiveness contiguity)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.Inclusive_Constant:
                    contiguity = Inclusiveness.Exclusive;
                    break;

                case ITexts.Exclusive_Constant:
                    contiguity = Inclusiveness.Inclusive;
                    break;

                default:
                    contiguity = default;
                    output = false;
                    break;
            }

            return output;
        }
    }
}
