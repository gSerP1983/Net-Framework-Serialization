using System.IO;
using System.Runtime.Serialization;

namespace Serialization.Lib
{
    public class DataContractSerializerImpl<T> : ISerializer<T>
    {
        private readonly DataContractSerializer _formatterInner = new DataContractSerializer(typeof(T));

        public DataContractSerializer Formatter
        {
            get { return _formatterInner; }
        }

        public void Serialize(Stream serializationStream, T graph)
        {
            _formatterInner.WriteObject(serializationStream, graph);
        }

        public T Deserialize(Stream serializationStream)
        {
            return (T) _formatterInner.ReadObject(serializationStream);
        }
    }
}
