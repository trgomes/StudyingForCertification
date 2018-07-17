using System.IO;
using System.Web.Script.Serialization;

namespace _01_Generics
{
    public class Serialization
    {
        public static void Serialize(object obj)
        {
            StreamWriter sw = new StreamWriter(@"D:\Users\Thiago\Documents\03-"+ obj.GetType().Name +".txt");

            JavaScriptSerializer serialization = new JavaScriptSerializer();
            string objSerialized = serialization.Serialize(obj);

            sw.Write(objSerialized);
            sw.Close();
        }

        public static T Deserialize<T>()
        {
            StreamReader sr = new StreamReader(@"D:\Users\Thiago\Documents\03-" + typeof(T).Name + ".txt");
            string data = sr.ReadToEnd();

            JavaScriptSerializer serialization = new JavaScriptSerializer();
            T obj = (T)serialization.Deserialize(data, typeof(T));

            return obj;

        }
    }
}
