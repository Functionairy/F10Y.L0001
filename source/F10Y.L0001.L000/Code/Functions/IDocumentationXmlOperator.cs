using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using F10Y.T0002;


namespace F10Y.L0001.L000
{
    /// <summary>
    /// Functions related to .NET XML documentation.
    /// </summary>
    [FunctionsMarker]
    public partial interface IDocumentationXmlOperator
    {
        IEnumerable<XElement> Enumerate_MemberElements(XElement documentationElement)
        {
            var membersElement = this.Get_MembersElement(documentationElement);

            var output = Instances.XElementOperator.Enumerate_ChildElements(membersElement);
            return output;
        }

        IEnumerable<XElement> Enumerate_MemberElements_Cloned(XElement documentationElement)
        {
            var membersElement = this.Get_MembersElement(documentationElement);

            var output = Instances.XElementOperator.Enumerate_ChildElements_Cloned(membersElement);
            return output;
        }

        XElement Get_AssemblyElement(XElement documentationElement)
            => Instances.XElementOperator.Get_ChildElement(
                documentationElement,
                Instances.DocumentationXmlNodeNames.assembly);

        string Get_AssemblyName(XElement documentationElement)
        {
            var assemblyElement = this.Get_AssemblyElement(documentationElement);

            var nameElement = Instances.XElementOperator.Get_ChildElement(
                assemblyElement,
                Instances.DocumentationXmlNodeNames.name);

            var output = Instances.XElementOperator.Get_Value(
                nameElement);

            return output;
        }

        XElement Get_DocumentationElement(XDocument documentationDocument)
        {
            var output = Instances.XDocumentOperator.Get_Root(
                documentationDocument,
                Instances.DocumentationXmlNodeNames.doc);

            return output;
        }

        string Get_Member_IdentityString(XElement member)
            => Instances.XElementOperator.Get_Attribute_Value(
                member,
                Instances.DocumentationXmlNodeNames.name);

        XElement[] Get_MemberElements(XElement documentation)
            => this.Enumerate_MemberElements(documentation)
            .ToArray();

        Dictionary<string, XElement> Get_MemberElements_ByIdentityString(XDocument documentation)
        {
            var documentationElement = this.Get_DocumentationElement(documentation);

            var output = this.Get_MemberElements_ByIdentityString(documentationElement);
            return output;
        }

        Dictionary<string, XElement> Get_MemberElements_ByIdentityString(XElement documentationElement)
        {
            var output = this.Enumerate_MemberElements(documentationElement)
                .ToDictionary(this.Get_Member_IdentityString);

            return output;
        }

        XElement Get_MembersElement(XElement documentationElement)
            => Instances.XElementOperator.Get_ChildElement(
                documentationElement,
                Instances.DocumentationXmlNodeNames.members);

        bool Is_DocumentationDocument(XDocument document)
        {
            var root = Instances.XDocumentOperator.Get_Root(document);

            var output = this.Is_DocumentationElement(root);
            return output;
        }

        bool Is_DocumentationElement(XElement possibleDocumentationElement)
        {
            var name = Instances.XElementOperator.Get_Name(possibleDocumentationElement);

            var isNamedDoc = name == Instances.DocumentationXmlNodeNames.doc;
            if(!isNamedDoc)
            {
                return false;
            }

            var hasAssemblyChild = Instances.XElementOperator.Has_Child(
                possibleDocumentationElement,
                Instances.DocumentationXmlNodeNames.assembly,
                out _);

            if(!hasAssemblyChild)
            {
                return false;
            }

            // Else.
            return true;
        }
    }
}
