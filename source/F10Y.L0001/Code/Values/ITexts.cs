using System;

using F10Y.T0003;


namespace F10Y.L0001
{
    [ValuesMarker]
    public partial interface ITexts
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>&lt;none&gt;</value></para>
        /// </summary>
        public string none_Standard => "<none>";

        /// <summary>
        /// <para><value>&lt;None&gt;</value></para>
        /// </summary>
        public string None_Bracketed => "<None>";

        /// <inheritdoc cref="None"/>
        public string None_Capitalized => this.NONE;

        /// <summary>
        /// Chooses <see cref="None_Bracketed"/> (<inheritdoc cref="None_Bracketed" path="descendant::value"/>) as the standard None text.
        /// </summary>
        public string None_Standard => this.None_Bracketed;

        /// <summary>
        /// Chooses <see cref="None_Standard"/> (<inheritdoc cref="None_Standard" path="descendant::value"/>) as the default None text.
        /// </summary>
        public string None => this.None_Standard;

        /// <summary>
        /// <para><value>null</value></para>
        /// </summary>
        public string @null => "null";

        /// <summary>
        /// <para><value>&lt;null&gt;</value></para>
        /// </summary>
        public string null_Bracketed => "<null>";

        /// <summary>
        /// Chooses <see cref="@null"/> (<inheritdoc cref="@null" path="descendant::value"/>) as the default null text.
        /// </summary>
        public string null_Standard => this.@null;

        /// <summary>
        /// Chooses <see cref="null_Standard"/> (<inheritdoc cref="null_Standard" path="descendant::value"/>) as the default null text.
        /// </summary>
        public string Null => this.null_Standard;

        /// <summary>
        /// <para><value>ALL</value></para>
        /// </summary>
        public const string ALL_Constant = "ALL";

        /// <inheritdoc cref="ALL_Constant"/>
        public string ALL => ANY_Constant;

        /// <summary>
        /// <para><value>ANY</value></para>
        /// </summary>
        public const string ANY_Constant = "ANY";

        /// <inheritdoc cref="ANY_Constant"/>
        public string ANY => ANY_Constant;

        /// <summary>
        /// <para><value>Contiguous</value></para>
        /// </summary>
        public const string Contiguous_Constant = "Contiguous";

        /// <inheritdoc cref="Contiguous_Constant"/>
        public string Contiguous => Contiguous_Constant;

        /// <summary>
        /// <para><value>Exclusive</value></para>
        /// </summary>
        public const string Exclusive_Constant = "Exclusive";

        /// <inheritdoc cref="Exclusive_Constant"/>
        public string Exclusive => Exclusive_Constant;

        /// <summary>
        /// <para><value>exists</value></para>
        /// </summary>
        public string exists => "exists";

        /// <summary>
        /// <para><value>Inclusive</value></para>
        /// </summary>
        public const string Inclusive_Constant = "Inclusive";

        /// <inheritdoc cref="Inclusive_Constant"/>
        public string Inclusive => Inclusive_Constant;

        /// <summary>
        /// <para><value>missing</value></para>
        /// </summary>
        public string missing => "missing";

        /// <summary>
        /// <para><value>Non-Contiguous</value></para>
        /// </summary>
        public const string NonContiguous_Constant = "Non-Contiguous";

        /// <inheritdoc cref="NonContiguous_Constant"/>
        public string NonContiguous => NonContiguous_Constant;

        /// <summary>
        /// <para><value>NONE</value></para>
        /// </summary>
        public const string NONE_Constant = "NONE";

        /// <inheritdoc cref="NONE_Constant"/>
        public string NONE => NONE_Constant;

        /// <summary>
        /// <para><value>Order Dependent</value></para>
        /// </summary>
        public const string OrderDependent_Constant = "Order Dependent";

        /// <inheritdoc cref="OrderDependent_Constant"/>
        public string OrderDependent => OrderDependent_Constant;

        /// <summary>
        /// <para><value>Order Independent</value></para>
        /// </summary>
        public const string OrderIndependent_Constant = "Order Independent";

        /// <inheritdoc cref="OrderIndependent_Constant"/>
        public string OrderIndependent => OrderIndependent_Constant;

        /// <summary>
        /// <para><value>Private</value></para>
        /// </summary>
        public const string Private_Constant = "Private";

        /// <inheritdoc cref="Private_Constant"/>
        public string Private => Private_Constant;

        /// <summary>
        /// <para><value>Public</value></para>
        /// </summary>
        public const string Public_Constant = "Public";

        /// <inheritdoc cref="Public_Constant"/>
        public string Public => Public_Constant;

        /// <summary>
        /// <para><value>Sub</value></para>
        /// </summary>
        public const string Sub_Constant = "Sub";

        /// <inheritdoc cref="Sub_Constant"/>
        public string Sub => Sub_Constant;

        /// <summary>
        /// <para><value>Super</value></para>
        /// </summary>
        public const string Super_Constant = "Super";

        /// <inheritdoc cref="Super_Constant"/>
        public string Super => Super_Constant;

#pragma warning restore IDE1006 // Naming Styles
    }
}
