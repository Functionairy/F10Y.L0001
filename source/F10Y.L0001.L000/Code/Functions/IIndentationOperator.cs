using System;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IIndentationOperator
    {
        /// <summary>
        /// Get a new indentation tracker ready for use.
        /// </summary>
        IndentationTracker New_IndentationTracker()
            => new IndentationTracker();

        string Get_IndentationLine(
            IndentationTracker indentationTracker,
            string newLine)
        {
            var output = Instances.StringOperator.Concatenate(
                newLine,
                indentationTracker.Indentation);

            return output;
        }

        /// <inheritdoc cref="Get_IndentationLine(IndentationTracker, string)"/>.
        /// <remarks>
        /// Uses <see cref="L0000.INewLines.Environment"/> as the new line.
        /// </remarks>
        string Get_IndentationLine(IndentationTracker indentationTracker)
            => this.Get_IndentationLine(
                indentationTracker,
                Instances.NewLines.Environment);
    }
}
