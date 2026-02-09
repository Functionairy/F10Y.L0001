using System;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    /// <summary>
    /// Functions for getting the duration of various operations.
    /// </summary>
    [FunctionsMarker]
    public partial interface IDurationOperator
    {
        /// <summary>
        /// Gets a end time for use in <see cref="Get_Duration(DateTime, DateTime)"/>.
        /// </summary>
        DateTime Get_End()
            => Instances.NowOperator.Get_Now_Local();

        /// <summary>
        /// Gets a start time for later use in <see cref="Get_Duration(DateTime, DateTime)"/>.
        /// </summary>
        DateTime Get_Start()
            => Instances.NowOperator.Get_Now_Local();

        TimeSpan Get_Duration(
            DateTime start,
            DateTime end)
        {
            var output = end - start;
            return output;
        }

        TimeSpan Get_Duration(DateTime start)
        {
            var end = this.Get_End();

            var output = this.Get_Duration(
                start,
                end);

            return output;
        }
    }
}
