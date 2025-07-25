using System;

using F10Y.T0002;

using F10Y.L0001.T000;


namespace F10Y.L0001
{
    /// <summary>
    /// Operator for the <see cref="OrderDependence"/> enumeration.
    /// </summary>
    [FunctionsMarker]
    public partial interface IOrderDependenceOperator
    {
        public T Switch<T>(
            OrderDependence orderDependence,
            T for_OrderDependent,
            T for_OrderIndependent)
        {
            var output = orderDependence switch
            {
                OrderDependence.OrderDependent => for_OrderDependent,
                OrderDependence.OrderIndependent => for_OrderIndependent,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(orderDependence)
            };

            return output;
        }

        /// <summary>
        /// Converts a visibility from its standard string representation.
        /// </summary>
        /// <inheritdoc cref="To_String_Standard(OrderDependence)" path="/remarks"/>
        public OrderDependence From_String_Standard(string orderDependence)
        {
            var output = orderDependence switch
            {
                ITexts.OrderDependent_Constant => OrderDependence.OrderDependent,
                ITexts.OrderIndependent_Constant => OrderDependence.OrderIndependent,
                _ => throw Instances.SwitchOperator.Get_UnrecognizedEnumerationValueException<OrderDependence>(orderDependence)
            };

            return output;
        }

        /// <summary>
        /// Chooses <see cref="From_String_Standard(string)"/> as the default.
        /// </summary>
        public OrderDependence From_String(string orderDependence)
        {
            var output = this.From_String_Standard(orderDependence);
            return output;
        }

        /// <summary>
        /// Converts a visibility to its standard string representation.
        /// </summary>
        /// <remarks>
        /// The standard strings are:
        /// <list type="bullet">
        /// <item><inheritdoc cref="ITexts.OrderDependent" path="descendant::value"/></item>
        /// <item><inheritdoc cref="ITexts.OrderIndependent" path="descendant::value"/></item>
        /// </list>
        /// </remarks>
        public string To_String_Standard(OrderDependence orderDependence)
        {
            var output = this.Switch(
                orderDependence,
                Instances.Texts.OrderDependent,
                Instances.Texts.OrderIndependent);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="To_String_Standard(OrderDependence)"/> as the default.
        /// </summary>
        public string To_String(OrderDependence orderDependence)
        {
            var output = this.To_String_Standard(orderDependence);
            return output;
        }

        public bool Try_Parse(
            string representation,
            out OrderDependence orderDependence)
        {
            var output = true;

            switch (representation)
            {
                case ITexts.OrderDependent_Constant:
                    orderDependence = OrderDependence.OrderDependent;
                    break;

                case ITexts.OrderIndependent_Constant:
                    orderDependence = OrderDependence.OrderIndependent;
                    break;

                default:
                    orderDependence = default;
                    output = false;
                    break;
            }

            return output;
        }
    }
}
