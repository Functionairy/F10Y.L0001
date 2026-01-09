using System;


namespace F10Y.L0001.Extensions
{
    public static class TypeSpecifierExtensions
    {
        public static TypeSpecifier<T1> Get_First<T1, T2>(this TypeSpecifier<T1, T2> typeSpecifier)
            => Instances.TypeSpecifierOperator.Get_First(typeSpecifier);

        public static TypeSpecifier<T2> Get_Second<T1, T2>(this TypeSpecifier<T1, T2> typeSpecifier)
            => Instances.TypeSpecifierOperator.Get_Second(typeSpecifier);
    }
}
