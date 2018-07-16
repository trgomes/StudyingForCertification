using _00_Library;
using System.IO;
using System.Web.Script.Serialization;

namespace _03_SerializeJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User {
                Name = "Maria",
                CPF = "333.333.333-33",
                Email = "mail@mail.com"
            };

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string stringJsonSerialize = serializer.Serialize(user);

            StreamWriter sw = new StreamWriter(@"D: \Users\Thiago\Documents\02-SerializeJSON.json");
            sw.WriteLine(stringJsonSerialize);

            sw.Close();



        }
    }
}
