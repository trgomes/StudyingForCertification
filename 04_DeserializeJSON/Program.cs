using _00_Library;
using System;
using System.IO;
using System.Web.Script.Serialization;

namespace _04_DeserializeJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D: \Users\Thiago\Documents\02-SerializeJSON.json");
            string fileLine = sr.ReadToEnd();

            JavaScriptSerializer serialize = new JavaScriptSerializer();
            serialize.Deserialize(fileLine, typeof(User));

            User user = (User)serialize.Deserialize(fileLine, typeof(User));

            Console.WriteLine($"Name: {user.Name} | CPF: {user.CPF} | Email: {user.Email}");

            Console.ReadKey();

        }
    }
}
