using System;

using F10Y.T0002;

using F10Y.L0001.T000;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface IVisibilityOperator
    {
        public bool Are_Equal(
            Visibility a,
            Visibility b)
        {
            var output = a == b;
            return output;
        }

        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(Visibility)" path="/remarks"/>
        public Visibility From_String_Standard(string visibility)
        {
            var output = visibility switch
            {
                ITexts.Private_Constant => Visibility.Private,
                ITexts.Public_Constant => Visibility.Public,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<Visibility>(visibility)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public Visibility From_String(string visibility)
        {
            var output = this.From_String_Standard(visibility);
            return output;
        }

        /// <summary>
        /// Converts a visibility to its standard string representation.
        /// </summary>
        /// <remarks>
        /// The standard strings are:
        /// <list type="bullet">
        /// <item><inheritdoc cref="ITexts.Private" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.Public" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(Visibility visibility)
        {
            var output = visibility switch
            {
                Visibility.Private => Instances.Texts.Private,
                Visibility.Public => Instances.Texts.Public,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(visibility)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(Visibility)"/> as the default.
        /// </summary>
        public string To_String(Visibility visibility)
        {
            var output = this.To_String_Standard(visibility);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out Visibility visibility)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.Private_Constant:
                    visibility = Visibility.Private;
                    break;

                case ITexts.Public_Constant:
                    visibility = Visibility.Public;
                    break;

                default:
                    visibility = default;
                    output = false;
                    break;
            }

            return output;
        }
    }
}
