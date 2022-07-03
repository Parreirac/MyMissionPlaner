
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MyMissionPlaner.Models.NC1Components
{
    public  class MyXmlElementAttribute : XmlElementAttribute
    {

        //
        // Résumé :
        //     Gets or sets the XML Schema definition (XSD) data type of the XML element generated
        //     by the System.Xml.Serialization.XmlSerializer.
        //
        // Retourne :
        //     An XML Schema data type.
        //
        // Exceptions :
        //   T:System.Exception:
        //     The XML Schema data type you have specified cannot be mapped to the.NET data
        //     type.
  /*      public new string DataType
        {
            [System.Runtime.CompilerServices.NullableContext(1)]
            get
            {
                throw null;
            }
            [System.Runtime.CompilerServices.NullableContext(1)]
            [param: AllowNull]
            set
            {
            }
        }*/

        //
        // Résumé :
        //     Gets or sets the name of the generated XML element.
        //
        // Retourne :
        //     The name of the generated XML element. The default is the member identifier.
  /*      public new string ElementName
        {
            [System.Runtime.CompilerServices.NullableContext(1)]
            get
            {
                throw null;
            }
            [System.Runtime.CompilerServices.NullableContext(1)]
            [param: AllowNull]
            set
            {
            }
        }*/

        //
        // Résumé :
        //     Gets or sets a value that indicates whether the element is qualified.
        //
        // Retourne :
        //     One of the System.Xml.Schema.XmlSchemaForm values. The default is System.Xml.Schema.XmlSchemaForm.None.
/*        public new XmlSchemaForm Form
        {
            get
            {
                throw null;
            }
            set
            {
            }
        }*/

        //
        // Résumé :
        //     Gets or sets a value that indicates whether the System.Xml.Serialization.XmlSerializer
        //     must serialize a member that is set to null as an empty tag with the xsi:nil
        //     attribute set to true.
        //
        // Retourne :
        //     true if the System.Xml.Serialization.XmlSerializer generates the xsi:nil attribute;
        //     otherwise, false.
  /*      public new bool IsNullable
        {
            get
            {
                throw null;
            }
            set
            {
            }
        }*/

        //
        // Résumé :
        //     Gets or sets the namespace assigned to the XML element that results when the
        //     class is serialized.
        //
        // Retourne :
        //     The namespace of the XML element.
 /*       public new string? Namespace
        {
            get
            {
                throw null;
            }
            set
            {
            }
        }*/

        //
        // Résumé :
        //     Gets or sets the explicit order in which the elements are serialized or deserialized.
        //
        // Retourne :
        //     The order of the code generation.
  /*      public new int Order
        {
            get
            {
                throw null;
            }
            set
            {
            }
        }*/

        //
        // Résumé :
        //     Gets or sets the object type used to represent the XML element.
        //
        // Retourne :
        //     The System.Type of the member.
  /*      public new Type? Type
        {
            get
            {
                throw null;
            }
            set
            {
            }
        }*/

        //
        // Résumé :
        //     Initializes a new instance of the System.Xml.Serialization.XmlElementAttribute
        //     class.
        public MyXmlElementAttribute():base()
        {}


        //
        // Résumé :
        //     Initializes a new instance of the System.Xml.Serialization.XmlElementAttribute
        //     class and specifies the name of the XML element.
        //
        // Paramètres :
        //   elementName:
        //     The XML element name of the serialized member.
        public MyXmlElementAttribute(string? elementName):base(elementName) 
        {
            if (elementName != null)
                Type = System.Type.GetType(elementName);
        }

        //
        // Résumé :
        //     Initializes a new instance of the System.Xml.Serialization.XmlElementAttribute
        //     and specifies the name of the XML element and a derived type for the member to
        //     which the System.Xml.Serialization.XmlElementAttribute is applied. This member
        //     type is used when the System.Xml.Serialization.XmlSerializer serializes the object
        //     that contains it.
        //
        // Paramètres :
        //   elementName:
        //     The XML element name of the serialized member.
        //
        //   type:
        //     The System.Type of an object derived from the member's type.
        public MyXmlElementAttribute(string? elementName, Type? type):base(elementName, type)
        {
        }

        //
        // Résumé :
        //     Initializes a new instance of the System.Xml.Serialization.XmlElementAttribute
        //     class and specifies a type for the member to which the System.Xml.Serialization.XmlElementAttribute
        //     is applied. This type is used by the System.Xml.Serialization.XmlSerializer when
        //     serializing or deserializing object that contains it.
        //
        // Paramètres :
        //   type:
        //     The System.Type of an object derived from the member's type.
        public MyXmlElementAttribute(Type? type):base(type)
        {
        }



    }
}
