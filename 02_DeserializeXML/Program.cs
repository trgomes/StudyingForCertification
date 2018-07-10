using _00_Library;
using System;
using System.IO;
using System.Xml.Serialization;

namespace _02_DeserializeXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"D:\Users\Thiago\Documents\01-SerializeXML.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(User));
            User user = (User)serializer.Deserialize(stream);

            Console.WriteLine($"Name: {user.Name}, CPF: {user.CPF}, Email: {user.Email}");

            Console.ReadKey();
        }
    }
}
