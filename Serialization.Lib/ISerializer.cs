using System.IO;

namespace Serialization.Lib
{
    public interface ISerializer<T>
    {
        void Serialize(Stream serializationStream, T graph);
        T Deserialize(Stream serializationStream);
    }
}
