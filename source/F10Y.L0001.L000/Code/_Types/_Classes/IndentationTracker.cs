using System;

using F10Y.T0004;


namespace F10Y.L0001.L000
{
    /// <summary>
    /// Allows tracking indentation, which is useful during serialization.
    /// </summary>
    [UtilityTypeMarker]
    public class IndentationTracker
    {
        /// <inheritdoc cref="L0000.IStrings.Tab_Constant"/>
        public const string IndentationUnit_Tab = IStrings.Tab_Constant;

        public const string IndentationUnit_Spaces_Two = "  ";

        public const string IndentationUnit_Spaces_Four = "    ";

        /// <inheritdoc cref="IndentationUnit_Spaces_Four" />
        /// <remarks>
        /// Chooses <see cref="IndentationUnit_Spaces_Four"/> as the default.
        /// </remarks>
        public const string IndentationUnit_Default = IndentationUnit_Spaces_Four;


        public Incrementer Level { get; } = new Incrementer();

        /// <summary>
        /// The unit of indentation (examples: tab, or 4 spaces, or 2 spaces).
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="IndentationUnit_Default"/>.
        /// </remarks>
        public string IndentationUnit { get; set; } = IndentationTracker.IndentationUnit_Default;

        public string Indentation => this.Get_Indentation();


        public string Get_Indentation()
        {
            var output = Instances.StringOperator.Repeat(
                this.IndentationUnit,
                this.Level.Level);

            return output;
        }

        /// <summary>
        /// Resets the indentation level to zero.
        /// </summary>
        public void Reset()
        {
            this.Level.Reset();
        }

        /// <summary>
        /// Add one (1) to the indentation level.
        /// </summary>
        public void Increase()
        {
            this.Level.Increment();
        }

        /// <summary>
        /// Subtracts one (1) from the indentation level.
        /// </summary>
        public void Decrease()
        {
            this.Level.Decrement();
        }

        public void Indent(Action action)
        {
            this.Increase();

            action();

            this.Decrease();
        }
    }
}
