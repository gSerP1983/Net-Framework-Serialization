using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization.Lib
{
    public class BinaryFormatterSerializerImpl<T> : ISerializer<T>
    {
        private readonly BinaryFormatter _formatterInner = new BinaryFormatter();

        public BinaryFormatter Formatter
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
