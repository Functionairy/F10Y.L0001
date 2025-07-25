using System;

using F10Y.T0002;

using F10Y.L0001.T000;


namespace F10Y.L0001
{
    /// <summary>
    /// Operator for the <see cref="Contiguity"/> enumeration.
    /// </summary>
    [FunctionsMarker]
    public partial interface IContiguityOperator
    {
        public T Switch<T>(
            Contiguity contiguity,
            T for_Contiguous,
            T for_Noncontiguous)
        {
            var output = contiguity switch
            {
                Contiguity.Contiguous => for_Contiguous,
                Contiguity.Noncontiguous => for_Noncontiguous,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(contiguity)
            };

            return output;
        }

        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(Contiguity)" path="/remarks"/>
        public Contiguity From_String_Standard(string contiguity)
        {
            var output = contiguity switch
            {
                ITexts.Contiguous_Constant => Contiguity.Contiguous,
                ITexts.NonContiguous_Constant => Contiguity.Noncontiguous,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<Contiguity>(contiguity)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public Contiguity From_String(string contiguity)
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
        /// <item><inheritdoc cref="ITexts.Contiguous" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.NonContiguous" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(Contiguity contiguity)
        {
            var output = this.Switch(
                contiguity,
                Instances.Texts.Contiguous,
                Instances.Texts.NonContiguous);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(Contiguity)"/> as the default.
        /// </summary>
        public string To_String(Contiguity contiguity)
        {
            var output = this.To_String_Standard(contiguity);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out Contiguity contiguity)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.Contiguous_Constant:
                    contiguity = Contiguity.Contiguous;
                    break;

                case ITexts.NonContiguous_Constant:
                    contiguity = Contiguity.Noncontiguous;
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
