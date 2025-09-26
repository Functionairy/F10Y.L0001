using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IConsoleOperator :
        L0000.IConsoleOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IConsoleOperator _L0000 => L0000.ConsoleOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        int Write_StatusMessage_IndexOfCount(
            int index,
            int count)
        {
            this.Write_Line($"{index++}/{count}");

            return index;
        }

        int Write_StatusMessage_IndexOfCount(
            int index,
            int count,
            string message)
        {
            this.Write_Line($"{index++}/{count}: {message}");

            return index;
        }

        void Press_AnyKeyToClose()
        {
            this.Write(Instances.Texts.PressAnyKeyToClose);

            this.Read_Key();
        }
    }
}
