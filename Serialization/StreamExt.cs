using System.IO;

namespace Serialization
{
    public static class StreamExt
    {
        public static string AsString(this Stream stream)
        {
            stream.Position = 0;
            var sr = new StreamReader(stream);
            return sr.ReadToEnd();
        }
    }
}