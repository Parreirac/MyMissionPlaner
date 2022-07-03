using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MyMissionPlaner.Helpers
{
    public class MyXmlResolver : XmlResolver
     {

        // System.Xml.XmlConfiguration.XmlReaderSection.CreateDefaultResolver();
      //  https://www.dotnetframework.org/default.aspx/4@0/4@0/DEVDIV_TFS/Dev10/Releases/RTMRel/ndp/fx/src/Xml/System/Xml/XmlResolver@cs/1305376/XmlResolver@cs
        public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
        {
            return null;
        }

        public virtual new  Uri ResolveUri(Uri? baseUri, string? relativeUri)
        { 
        
        return base.ResolveUri(baseUri, relativeUri);
        }

        public virtual new bool SupportsType(Uri absoluteUri, Type? type)
        {
        return base.SupportsType(absoluteUri, type);    
        }
    }

    public class MyXmlSerializationReader : XmlSerializationReader
    {

        public XmlSerializationReader SourceReader { get; internal set; }// = null;

        protected override void InitCallbacks()
        {
    //        SourceReader.InitCallbacks();// SourceReader.In
          //  throw new NotImplementedException();
        }

        protected override void InitIDs()
        {
            throw new NotImplementedException();
        }

        public static MyXmlSerializationReader Get(XmlSerializationReader sourceReader)
        {
            return new MyXmlSerializationReader() { SourceReader = sourceReader };
         //   _sourceReader = sourceReader
        }
    }
    public class MyXmlSerializer : XmlSerializer  // serializer = new XmlSerializer(t);//
    {
        private XmlDeserializationEvents XDE = new XmlDeserializationEvents();

        #region constructeurs
        public MyXmlSerializer(Type type) : base(type)
        { Init();}

        public MyXmlSerializer(XmlTypeMapping xmlTypeMapping) : base(xmlTypeMapping)
        { Init(); }

        public MyXmlSerializer(Type type, string defaultNamespace) : base(type, defaultNamespace)
        { Init(); }

        public MyXmlSerializer(Type type, Type[] extraTypes) : base(type, extraTypes)
        { Init(); }

        public MyXmlSerializer(Type type, XmlAttributeOverrides overrides) : base(type, overrides)
        { Init(); }

        public MyXmlSerializer(Type type, XmlRootAttribute root) : base(type, root)
        { Init(); }

        public MyXmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) : base(type, overrides, extraTypes, root, defaultNamespace)
        { Init(); }

        public MyXmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location) : base(type, overrides, extraTypes, root, defaultNamespace, location)
        { Init(); }

        protected MyXmlSerializer()
        { Init(); }

        #endregion 

        private void Init()
        {
            /* If the XML document has been altered with unknown nodes or attributes, handle them with the
    UnknownNode and UnknownAttribute events.*/

                       this.UnknownNode += (sender, e) =>//(object sender, XmlNodeEventArgs e)
                        {
                            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
                        };

            this.UnknownAttribute += (sender, e) =>// (object sender, XmlAttributeEventArgs e)
                        {
                            //      System.Xml.XmlAttribute attr = e.Attr;
                            Console.WriteLine("Unknown attribute ");// + attr.Name + "='" + attr.Value + "'");
                        };

            //delegate void XmlElementEventHandler(object? sender, XmlElementEventArgs e);
            this.UnknownElement += (sender, eventArgs) =>
                        {
                            Console.WriteLine("UnknownElement:");// + e.Name + "\t" + e.Text);
                        };

            this.UnreferencedObject += (sender, eventArgs) => // (object? sender, UnreferencedObjectEventArgs e);
                        {
                            Console.WriteLine("UnknownElement:");// + e.Name + "\t" + e.Text);
                        };


 //           XmlDeserializationEvents XDE = new XmlDeserializationEvents();

            this.XDE.OnUnknownAttribute += (sender, e) =>//(object sender, XmlAttributeEventArgs e)
            {
                Console.WriteLine("Unknown Attribute");
                Console.WriteLine("\t" + e.Attr.Name + " " + e.Attr.InnerXml);
                Console.WriteLine("\t LineNumber: " + e.LineNumber);
                Console.WriteLine("\t LinePosition: " + e.LinePosition);

     //           Group x = (Group)e.ObjectBeingDeserialized;
         //       Console.WriteLine(x.GroupName);
                Console.WriteLine(sender.ToString());
            };

            XDE.OnUnknownElement += (sender, e) =>// (object sender,XmlElementEventArgs  e)
            {

                Console.WriteLine("OnUnknownElement");// + attr.Name + "='" + attr.Value + "'");
            };


            XDE.OnUnknownNode += (sender, e) =>// (object? sender, XmlNodeEventArgs e)
            {

                Console.WriteLine
("UnknownNode Name: {0}", e.Name);
                Console.WriteLine
                ("UnknownNode LocalName: {0}", e.LocalName);
                Console.WriteLine
                ("UnknownNode Namespace URI: {0}", e.NamespaceURI);
                Console.WriteLine
                ("UnknownNode Text: {0}", e.Text);

                XmlNodeType myNodeType = e.NodeType;
                Console.WriteLine("NodeType: {0}", myNodeType);
                var v = e.ObjectBeingDeserialized;
                Console.WriteLine("OnUnknownNode:");// + e.Name + "\t" + e.Text);
            };

            XDE.OnUnreferencedObject += (sender, eventArgs) => // (object? sender, UnreferencedObjectEventArgs e);
            {
                Console.WriteLine("OnUnreferencedObject:");// + e.Name + "\t" + e.Text);
            };

        }

        //
        // Résumé :
        //     Returns an object used to read the XML document to be serialized.
        //
        // Retourne :
        //     An System.Xml.Serialization.XmlSerializationReader used to read the XML document.
        //
        // Exceptions :
        //   T:System.NotImplementedException:
        //     Any attempt is made to access the method when the method is not overridden in
        //     a descendant class.
        protected virtual new  XmlSerializationReader CreateReader()
        {
            XmlSerializationReader reader = base.CreateReader();
            return reader;
         //   throw null;
        }

        //
        // Résumé :
        //     Deserializes the XML document contained by the specified System.IO.Stream.
        //
        // Paramètres :
        //   stream:
        //     The System.IO.Stream that contains the XML document to deserialize.
        //
        // Retourne :
        //     The System.Object being deserialized.
        //  [RequiresUnreferencedCode("Members from deserialized types may be trimmed if not referenced directly")]
        public new object? Deserialize(Stream stream)
        {
   //          return base.Deserialize(stream);

           XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.XmlResolver = new MyXmlResolver();
            XmlReader reader = XmlReader.Create(stream, xrs);

            return Deserialize(reader, XDE);

      //      throw null;
        }

        //
        // Résumé :
        //     Deserializes the XML document contained by the specified System.IO.TextReader.
        //
        // Paramètres :
        //   textReader:
        //     The System.IO.TextReader that contains the XML document to deserialize.
        //
        // Retourne :
        //     The System.Object being deserialized.
        //
        // Exceptions :
        //   T:System.InvalidOperationException:
        //     An error occurred during deserialization. The original exception is available
        //     using the System.Exception.InnerException property.
   //     [RequiresUnreferencedCode("Members from deserialized types may be trimmed if not referenced directly")]
        public new object? Deserialize(TextReader textReader)
        {
            return base.Deserialize(textReader);
        }

        //
        // Résumé :
        //     Deserializes the XML document contained by the specified System.Xml.Serialization.XmlSerializationReader.
        //
        // Paramètres :
        //   reader:
        //     The System.Xml.Serialization.XmlSerializationReader that contains the XML document
        //     to deserialize.
        //
        // Retourne :
        //     The deserialized object.
        //
        // Exceptions :
        //   T:System.NotImplementedException:
        //     Any attempt is made to access the method when the method is not overridden in
        //     a descendant class.
        protected new virtual object Deserialize(XmlSerializationReader xmlReader)
        {
       //     XmlReader reader = XmlReader.Create(xmlReader);
        return base.Deserialize(xmlReader);
        //    return base.Deserialize(MyXmlSerializationReader.Get(xmlReader), XDE);
         //   throw null;
        }

        //
        // Résumé :
        //     Deserializes the XML document contained by the specified System.Xml.XmlReader.
        //
        // Paramètres :
        //   xmlReader:
        //     The System.Xml.XmlReader that contains the XML document to deserialize.
        //
        // Retourne :
        //     The System.Object being deserialized.
        //
        // Exceptions :
        //   T:System.InvalidOperationException:
        //     An error occurred during deserialization. The original exception is available
        //     using the System.Exception.InnerException property.
   //     [RequiresUnreferencedCode("Members from deserialized types may be trimmed if not referenced directly")]
        public new object? Deserialize(XmlReader xmlReader)
        {
            return base.Deserialize(xmlReader,XDE);
         //   throw null;
        }

        //
        // Résumé :
        //     Deserializes the XML document contained by the specified System.Xml.XmlReader
        //     and encoding style.
        //
        // Paramètres :
        //   xmlReader:
        //     The System.Xml.XmlReader that contains the XML document to deserialize.
        //
        //   encodingStyle:
        //     The encoding style of the serialized XML.
        //
        // Retourne :
        //     The deserialized object.
        //
        // Exceptions :
        //   T:System.InvalidOperationException:
        //     An error occurred during deserialization. The original exception is available
        //     using the System.Exception.InnerException property.
 //       [RequiresUnreferencedCode("Members from deserialized types may be trimmed if not referenced directly")]
        public new object? Deserialize(XmlReader xmlReader, string? encodingStyle)
        {
            return base.Deserialize(xmlReader, encodingStyle);
        }

        //
        // Résumé :
        //     Deserializes the object using the data contained by the specified System.Xml.XmlReader.
        //
        // Paramètres :
        //   xmlReader:
        //     An instance of the System.Xml.XmlReader class used to read the document.
        //
        //   encodingStyle:
        //     The encoding used.
        //
        //   events:
        //     An instance of the System.Xml.Serialization.XmlDeserializationEvents class.
        //
        // Retourne :
        //     The object being deserialized.
     //   [RequiresUnreferencedCode("Members from deserialized types may be trimmed if not referenced directly")]
        public new object? Deserialize(XmlReader xmlReader, string? encodingStyle, XmlDeserializationEvents events)
        {
            return base.Deserialize(xmlReader, encodingStyle, events);
 //           throw null;
        }

        //
        // Résumé :
        //     Deserializes an XML document contained by the specified System.Xml.XmlReader
        //     and allows the overriding of events that occur during deserialization.
        //
        // Paramètres :
        //   xmlReader:
        //     The System.Xml.XmlReader that contains the document to deserialize.
        //
        //   events:
        //     An instance of the System.Xml.Serialization.XmlDeserializationEvents class.
        //
        // Retourne :
        //     The System.Object being deserialized.
    //    [RequiresUnreferencedCode("Members from deserialized types may be trimmed if not referenced directly")]
        public new object? Deserialize(XmlReader xmlReader, XmlDeserializationEvents events)
        {
            return base.Deserialize(xmlReader,events);
           // throw null;
        }

    }
}
