using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0001
{
    [ValuesMarker]
    public partial interface ITexts :
        L000.ITexts
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L000.ITexts _L000 => L000.Texts.Instance;

#pragma warning restore IDE1006 // Naming Styles


#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>&lt;none&gt;</value></para>
        /// </summary>
        string none_Standard => "<none>";

        /// <summary>
        /// <para><value>&lt;None&gt;</value></para>
        /// </summary>
        string None_Bracketed => "<None>";

        /// <inheritdoc cref="None"/>
        string None_Capitalized => this.NONE;

        /// <summary>
        /// Chooses <see cref="None_Bracketed"/> (<inheritdoc cref="None_Bracketed" path="descendant::value"/>) as the standard None text.
        /// </summary>
        string None_Standard => this.None_Bracketed;

        /// <summary>
        /// Chooses <see cref="None_Standard"/> (<inheritdoc cref="None_Standard" path="descendant::value"/>) as the default None text.
        /// </summary>
        string None => this.None_Standard;

        /// <summary>
        /// Chooses <see cref="L000.ITexts.@null"/> (<inheritdoc cref="L000.ITexts.@null" path="descendant::value"/>) as the default null text.
        /// </summary>
        string null_Standard => this.@null;

        /// <summary>
        /// Chooses <see cref="null_Standard"/> (<inheritdoc cref="null_Standard" path="descendant::value"/>) as the default null text.
        /// </summary>
        string Null => this.null_Standard;

        /// <summary>
        /// <para><value>ALL</value></para>
        /// </summary>
        const string ALL_Constant = "ALL";

        /// <inheritdoc cref="ALL_Constant"/>
        string ALL => ANY_Constant;

        /// <summary>
        /// <para><value>ANY</value></para>
        /// </summary>
        const string ANY_Constant = "ANY";

        /// <inheritdoc cref="ANY_Constant"/>
        string ANY => ANY_Constant;

        /// <summary>
        /// <para><value>Contiguous</value></para>
        /// </summary>
        const string Contiguous_Constant = "Contiguous";

        /// <inheritdoc cref="Contiguous_Constant"/>
        string Contiguous => Contiguous_Constant;

        /// <summary>
        /// <para><value>Exclusive</value></para>
        /// </summary>
        const string Exclusive_Constant = "Exclusive";

        /// <inheritdoc cref="Exclusive_Constant"/>
        string Exclusive => Exclusive_Constant;

        /// <summary>
        /// <para><value>exists</value></para>
        /// </summary>
        string exists => "exists";

        /// <summary>
        /// <para><value>Inclusive</value></para>
        /// </summary>
        const string Inclusive_Constant = "Inclusive";

        /// <inheritdoc cref="Inclusive_Constant"/>
        string Inclusive => Inclusive_Constant;

        /// <summary>
        /// <para><value>missing</value></para>
        /// </summary>
        string missing => "missing";

        /// <summary>
        /// <para><value>Non-Contiguous</value></para>
        /// </summary>
        const string NonContiguous_Constant = "Non-Contiguous";

        /// <inheritdoc cref="NonContiguous_Constant"/>
        string NonContiguous => NonContiguous_Constant;

        /// <summary>
        /// <para><value>NONE</value></para>
        /// </summary>
        const string NONE_Constant = "NONE";

        /// <inheritdoc cref="NONE_Constant"/>
        string NONE => NONE_Constant;

        /// <summary>
        /// <para><value>Order Dependent</value></para>
        /// </summary>
        const string OrderDependent_Constant = "Order Dependent";

        /// <inheritdoc cref="OrderDependent_Constant"/>
        string OrderDependent => OrderDependent_Constant;

        /// <summary>
        /// <para><value>Order Independent</value></para>
        /// </summary>
        const string OrderIndependent_Constant = "Order Independent";

        /// <inheritdoc cref="OrderIndependent_Constant"/>
        string OrderIndependent => OrderIndependent_Constant;

        /// <summary>
        /// <para><value>Private</value></para>
        /// </summary>
        const string Private_Constant = "Private";

        /// <inheritdoc cref="Private_Constant"/>
        string Private => Private_Constant;

        /// <summary>
        /// <para><value>Public</value></para>
        /// </summary>
        const string Public_Constant = "Public";

        /// <inheritdoc cref="Public_Constant"/>
        string Public => Public_Constant;

        /// <summary>
        /// <para><value>Sub</value></para>
        /// </summary>
        const string Sub_Constant = "Sub";

        /// <inheritdoc cref="Sub_Constant"/>
        string Sub => Sub_Constant;

        /// <summary>
        /// <para><value>Super</value></para>
        /// </summary>
        const string Super_Constant = "Super";

        /// <inheritdoc cref="Super_Constant"/>
        string Super => Super_Constant;

#pragma warning restore IDE1006 // Naming Styles
    }
}
