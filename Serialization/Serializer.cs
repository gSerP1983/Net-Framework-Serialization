using System.IO;
using Serialization.Lib;

namespace Serialization
{
    internal static class Serializer
    {
        public static Stream Serialize<T>(ISerializer<T> serializer, T graph)
        {
            var stream = new MemoryStream();
            serializer.Serialize(stream, graph);
            return stream;
        }

        public static T Deserialize<T>(ISerializer<T> serializer, Stream stream)
        {
            return serializer.Deserialize(stream);
        }
    }
}
