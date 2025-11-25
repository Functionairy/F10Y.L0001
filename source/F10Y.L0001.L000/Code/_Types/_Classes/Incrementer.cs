using System;

using F10Y.T0004;


namespace F10Y.L0001.L000
{
    /// <summary>
    /// Allows tracking indentation level, which is useful during serialization.
    /// Incrementation is fixed to 1, and initial level is stated as zero.
    /// </summary>
    [UtilityTypeMarker]
    public class Incrementer
    {
        /// <summary>
        /// 0 (zero)
        /// </summary>
        public const int InitialLevel = 0;

        /// <summary>
        /// 1 (one)
        /// </summary>
        public const int Incrementation = 1;


        public int Level { get; set; }


        /// <summary>
        /// Resets the indentation level to zero.
        /// </summary>
        public void Reset()
        {
            this.Level = Incrementer.InitialLevel;
        }

        /// <summary>
        /// Add one (1) to the indentation level.
        /// </summary>
        public void Increment()
        {
            this.Level += Incrementer.Incrementation;
        }

        /// <summary>
        /// Subtracts one (1) from the indentation level.
        /// </summary>
        public void Decrement()
        {
            this.Level -= Incrementer.Incrementation;
        }
    }
}
