using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001
{
    [FunctionsMarker]
    public partial interface ITypeOperator :
        L0000.ITypeOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.ITypeOperator _L0000 => L0000.TypeOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        Func<TBase, TOutput> Get_Operator_WithInputTypeVerified<TBase, TDerived, TOutput>(
            Func<TDerived, TOutput> function_OfDerived)
            where TDerived : TBase
        {
            TOutput Internal(TBase value_Base)
            {
                this.Verify_Type_Is<TBase, TDerived>(
                    value_Base,
                    out var value_Derived);

                var output = function_OfDerived(value_Derived);
                return output;
            }

            return Internal;
        }

        Func<TBase, TArgument, TOutput> Get_Operator_WithInputTypeVerified<TBase, TArgument, TDerived, TOutput>(
            Func<TDerived, TArgument, TOutput> function_OfDerived)
            where TDerived : TBase
        {
            TOutput Internal(
                TBase value_Base,
                TArgument argument)
            {
                this.Verify_Type_Is<TBase, TDerived>(
                    value_Base,
                    out var value_Derived);

                var output = function_OfDerived(
                    value_Derived,
                    argument);

                return output;
            }

            return Internal;
        }

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

        bool If_TypeIs_ElseFalse<T, TDerived>(
            TDerived derived,
            T value,
            Func<TDerived, TDerived, bool> predicate)
            where TDerived : T
        {
            if (value is TDerived value_AsDerived)
            {
                var output = predicate(
                    derived,
                    value_AsDerived);

                return output;
            }

            return false;
        }

        bool Is_TypeName<T>(
            string typeName,
            out string typeName_OfTypeParameter)
        {
            typeName_OfTypeParameter = this.Get_TypeName_OfDeclaredType<T>();

            var output = typeName_OfTypeParameter == typeName;
            return output;
        }

        void Verify_TypeName<T>(string typeName)
        {
            var is_TypeName = this.Is_TypeName<T>(
                typeName,
                out var typeName_OfTypeParameter);

            if (!is_TypeName)
            {
                throw new Exception($"Type name mismatch. Expected: {typeName_OfTypeParameter}, found: {typeName}");
            }
        }
    }
}
