using System;


namespace F10Y.L0001
{
    public readonly struct TypeSpecifier<T>
    {
        #region Static

        public static TypeSpecifier<T> Instance { get; } = new TypeSpecifier<T>();

        #endregion
    }


    public readonly struct TypeSpecifier<T1, T2>
    {
        #region Static

        public static TypeSpecifier<T1, T2> Instance { get; } = new TypeSpecifier<T1, T2>();

        #endregion
    }


    public readonly struct TypeSpecifier<T1, T2, T3>
    {
        #region Static

        public static TypeSpecifier<T1, T2, T3> Instance { get; } = new TypeSpecifier<T1, T2, T3>();

        #endregion
    }
}
