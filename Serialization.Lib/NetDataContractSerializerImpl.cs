using System.IO;
using System.Runtime.Serialization;

namespace Serialization.Lib
{
    public class NetDataContractSerializerImpl<T> : ISerializer<T>
    {
        private readonly NetDataContractSerializer _formatterInner = new NetDataContractSerializer();

        public NetDataContractSerializer Formatter
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
