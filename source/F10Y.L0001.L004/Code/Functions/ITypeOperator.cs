using System;

using F10Y.T0002;
using F10Y.T0011;

using F10Y.L0001.T000;


namespace F10Y.L0001.L004
{
    [FunctionsMarker]
    public partial interface ITypeOperator :
        L000.ITypeOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L000.ITypeOperator _L000 => L000.TypeOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Func<TBase, TOutput> Get_Operator_WithInputTypeVerified<TBase, TDerived, TOutput>(
            Func<TDerived, TOutput> function_OfDerived,
            TypeSpecifier<TBase, TDerived> typeSpecifier)
            where TDerived : TBase
            => this.Get_Operator_WithInputTypeVerified<TBase, TDerived, TOutput>(function_OfDerived);

        Func<TBase, TArgument, TOutput> Get_Operator_WithInputTypeVerified<TBase, TArgument, TDerived, TOutput>(
            Func<TDerived, TArgument, TOutput> function_OfDerived,
            TypeSpecifier<TBase, TDerived> typeSpecifier)
            where TDerived : TBase
            => this.Get_Operator_WithInputTypeVerified<TBase, TArgument, TDerived, TOutput>(function_OfDerived);

        Func<TBase, TArgument, TOutput> Get_Operator_WithInputTypeVerified<TBase, TArgument, TDerived, TOutput>(
            Func<TDerived, TArgument, TOutput> function_OfDerived,
            TypeSpecifier<TBase, TDerived> typeSpecifier_Derivation,
            TypeSpecifier<TArgument> typeSpecifier_Argument)
            where TDerived : TBase
            => this.Get_Operator_WithInputTypeVerified<TBase, TArgument, TDerived, TOutput>(function_OfDerived);

        Func<TBase, TOutput> Get_Operator_WithInputTypeVerified<TBase, TDerived, TOutput>(
            Func<TDerived, TOutput> function_OfDerived,
            TypeSpecifier<TBase, TDerived, TOutput> typeSpecifier)
            where TDerived : TBase
            => this.Get_Operator_WithInputTypeVerified<TBase, TDerived, TOutput>(function_OfDerived);
    }
}
