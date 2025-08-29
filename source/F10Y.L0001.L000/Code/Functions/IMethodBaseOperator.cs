using System;
using System.Linq;
using System.Reflection;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0001.L000
{
    [FunctionsMarker]
    public partial interface IMethodBaseOperator :
        L0000.IMethodBaseOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0000.IMethodInfoOperator _L0000 => L0000.MethodInfoOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public Type[] Get_GenericTypeInputs_OfDeclaringType(MethodBase methodBase)
        {
            var declaringType = this.Get_DeclaringType(methodBase);

            var output = Instances.TypeOperator.Get_GenericTypeInputs(declaringType);
            return output;
        }

        public Type[] Get_GenericTypeInputs_OfMethodOnly(MethodBase methodBase)
        {
            var allGenericTypeInputs = this.Get_GenericTypeInputs_All(methodBase);

            var declaringTypeGenericTypeInputs = this.Get_GenericTypeInputs_OfDeclaringType(methodBase);

            var output = allGenericTypeInputs
                .Except(declaringTypeGenericTypeInputs,
                    NameBasedTypeEqualityComparer.Instance)
                .ToArray();

            return output;
        }

        /// <summary>
        /// Gets all generic type parameters of the method.
        /// This includes the generic type parameters of the declaring type of the method, and the method itself.
        /// </summary>
        public Type[] Get_GenericTypeParameters_All(MethodBase methodBase)
        {
            var output = methodBase.GetGenericArguments()
                .Where(Instances.TypeOperator.Is_GenericParameter)
                .ToArray();

            return output;
        }

        public Type[] Get_GenericTypeParameters(MethodBase methodBase)
        {
            var output = this.Get_GenericTypeParameters_All(methodBase);
            return output;
        }

        public ParameterInfo[] Get_InputParameters(MethodBase methodBase)
        {
            var output = methodBase.GetParameters();
            return output;
        }

        public string Get_MethodName(MethodBase methodBase)
        {
            var output = methodBase.Name;
            return output;
        }

        /// <summary>
        /// Returns the result of <see cref="MethodBase.GetParameters()"/>.
        /// </summary>
        public ParameterInfo[] Get_Parameters(MethodBase methodBase)
        {
            // After upgrade to MetadataLoadContext 8.0, parsing of function pointer types is supported.
            var output = methodBase.GetParameters();
            return output;
        }

        /// <summary>
        /// Determines whether the method has any generic type parameters.
        /// </summary>
        public bool Is_Generic(MethodBase methodBase)
        {
            var output = methodBase.IsGenericMethod;
            return output;
        }
    }
}
