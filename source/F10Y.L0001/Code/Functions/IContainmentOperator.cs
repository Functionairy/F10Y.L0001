using System;

using F10Y.T0002;

using F10Y.L0001.T000;


namespace F10Y.L0001
{
    /// <summary>
    /// Operator for the <see cref="Containment"/> enumeration.
    /// </summary>
    [FunctionsMarker]
    public partial interface IContainmentOperator
    {
        public T Switch<T>(
            Containment containment,
            T for_Sub,
            T for_Super)
        {
            var output = containment switch
            {
                Containment.Sub => for_Sub,
                Containment.Super => for_Super,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(containment)
            };

            return output;
        }

        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(Containment)" path="/remarks"/>
        public Containment From_String_Standard(string containment)
        {
            var output = containment switch
            {
                ITexts.Sub_Constant => Containment.Sub,
                ITexts.Super_Constant => Containment.Super,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<Containment>(containment)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public Containment From_String(string containment)
        {
            var output = this.From_String_Standard(containment);
            return output;
        }

        /// <summary>
        /// Converts a visibility to its standard string representation.
        /// </summary>
        /// <remarks>
        /// The standard strings are:
        /// <list type="bullet">
        /// <item><inheritdoc cref="ITexts.Sub" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.Super" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(Containment containment)
        {
            var output = this.Switch(
                containment,
                Instances.Texts.Sub,
                Instances.Texts.Super);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(Containment)"/> as the default.
        /// </summary>
        public string To_String(Containment containment)
        {
            var output = this.To_String_Standard(containment);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out Containment containment)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.Sub_Constant:
                    containment = Containment.Sub;
                    break;

                case ITexts.Super_Constant:
                    containment = Containment.Super;
                    break;

                default:
                    containment = default;
                    output = false;
                    break;
            }

            return output;
        }
    }
}
