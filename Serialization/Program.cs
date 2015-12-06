using System;
using Serialization.Lib;

namespace Serialization
{
    class Program
    {
        static void Main()
        {
            Do(new BinaryFormatterSerializerImpl<int>(), 27);
            Do(new DataContractJsonSerializerImpl<int>(), 03);
            Do(new DataContractSerializerImpl<int>(), 1983);
            Do(new NetDataContractSerializerImpl<int>(), 24);
            Do(new SoapFormatterSerializerImpl<int>(), 06);
            Do(new XmlSerializerImpl<int>(), 1987); 

            Console.ReadKey();
        }

        private static void Do<T>(ISerializer<T> serializer, T value)
        {
            Console.WriteLine("Serializer: {0}", serializer.GetType().Name);
            Console.WriteLine("Parameter: {0}", typeof(T).Name);

            var stream = Serializer.Serialize(serializer, value);
            Console.WriteLine(stream.AsString());

            stream.Position = 0;
            var d = Serializer.Deserialize(serializer, stream);
            Console.WriteLine("Deserialize succeeded: {0}", Equals(value, d));

            Console.WriteLine();
        }
    }
}

