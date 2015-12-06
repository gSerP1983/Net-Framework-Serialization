using System.IO;
using System.Runtime.Serialization.Json;

namespace Serialization.Lib
{
    public class DataContractJsonSerializerImpl<T> : ISerializer<T>
    {
        private readonly DataContractJsonSerializer _formatterInner = new DataContractJsonSerializer(typeof(T));

        public DataContractJsonSerializer Formatter
        {
            get { return _formatterInner; }
        }

        public void Serialize(Stream serializationStream, T graph)
        {
            _formatterInner.WriteObject(serializationStream, graph);
        }

        public T Deserialize(Stream serializationStream)
        {
            return (T)_formatterInner.ReadObject(serializationStream);
        }
    }
}
