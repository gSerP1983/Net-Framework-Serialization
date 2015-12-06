using System.IO;
using System.Xml.Serialization;

namespace Serialization.Lib
{
    public class XmlSerializerImpl<T> : ISerializer<T>
    {
        private readonly XmlSerializer _formatterInner = new XmlSerializer(typeof(T));

        public XmlSerializer Formatter
        {
            get { return _formatterInner; }
        }

        public void Serialize(Stream serializationStream, T graph)
        {            
            _formatterInner.Serialize(serializationStream, graph);
        }

        public T Deserialize(Stream serializationStream)
        {
            return (T) _formatterInner.Deserialize(serializationStream);
        }
    }
}
