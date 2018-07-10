using _00_Library;
using System.IO;
using System.Xml.Serialization;

namespace _01_SerializeXML
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() {
                Name = "João",
                CPF = "564.645.287.67",
                Email = "mail@mail.com"
            };

            XmlSerializer serializer = new XmlSerializer(typeof(User));

            StreamWriter stream = new StreamWriter(@"D:\Users\Thiago\Documents\01-SerializeXML.xml");

            serializer.Serialize(stream, user);
        }
    }
}
