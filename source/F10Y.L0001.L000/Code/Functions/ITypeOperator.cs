using System;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
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

        /// <summary>
        /// Get generic type inputs (either arguments, which are specified types like System.String, or parameters, which are unspecified like TKey).
        /// Note: handles any complications due to nesting, such as where the type might share generic inputs from it's nested parent type, by only returning generic types inputs that are not generic type inputs of any nested parents.
        /// </summary>
        Type[] Get_GenericTypeInputs_NotInParents(Type type)
        {
            var genericTypeInputsOfType = this.Get_GenericTypeInputs_OfType(type);

            var isNested = this.Is_NestedType(type);
            if (isNested)
            {
                var nestedParentType = this.Get_NestedTypeParentType(type);

                // Get the generic type inputs of the parent, including any that are of the parent's parent.
                var nestedParentGenericTypeInputs = this.Get_GenericTypeInputs_OfType(nestedParentType);

                // New generic types inputs in this type that are not in the parent, which are assumed to be just those types after the generic types of the parent.
                var output = genericTypeInputsOfType.Skip(nestedParentGenericTypeInputs.Length)
                    .ToArray();

                return output;
            }
            else
            {
                // If not nested, just return all generic type inputs of the type.
                return genericTypeInputsOfType;
            }
        }

        /// <summary>
        /// Get generic type inputs (either arguments, which are specified types like System.String, or parameters, which are unspecified like TKey).
        /// Note: gets the generic type inputs of the type (without handling any complications due to nesting, where the type might share generic inputs from it's nested parent type).
        /// </summary>
        Type[] Get_GenericTypeInputs_OfType(Type type)
        {
            // The GetGenericArguments() method returns both type parameters of a generic type definition,
            // and the generic type arguments of a closed generic type.
            var output = type.GetGenericArguments();
            return output;
        }

        /// <summary>
        /// Chooses <see cref="Get_GenericTypeInputs_NotInParents(Type)"/> as the default, since in general all we really want are the *new* generic inputs of the type.
        /// If you want all the raw generic inputs of the type, use <see cref="Get_GenericTypeInputs_OfType(Type)"/>.
        /// </summary>
        Type[] Get_GenericTypeInputs(Type type)
        {
            var output = this.Get_GenericTypeInputs_NotInParents(type);
            return output;
        }

        /// <summary>
        /// The parent of a nested type is the type's <see cref="Type.DeclaringType"/>.
        /// </summary>
        Type Get_NestedTypeParentType(Type type)
        {
            var output = type.DeclaringType;
            return output;
        }
    }
}
