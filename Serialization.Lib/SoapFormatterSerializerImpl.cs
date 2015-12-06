using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization.Lib
{
    /// <typeparam name="T">Must marked as serializable</typeparam>
    public class SoapFormatterSerializerImpl<T> : ISerializer<T>
    {
        private readonly SoapFormatter _formatterInner = new SoapFormatter();

        public SoapFormatter Formatter
        {
            get { return _formatterInner; }
        }

        public void Serialize(Stream serializationStream, T graph) 
        {
            _formatterInner.Serialize(serializationStream, graph);
        }

        public T Deserialize(Stream serializationStream)
        {
            return (T)_formatterInner.Deserialize(serializationStream);
        }
    }
}
