using System;
using _01_Generics.Models;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User { Name = "Juca", Email = "mail@mail.com", Password = "1234" };
            Home home = new Home { City = "SJC", Address = "SQL, 430" };
            Car car = new Car { Brand = "Fiat", Model = "Uno" };

            Serialization.Serialize(user);
            Serialization.Serialize(home);
            Serialization.Serialize(car);

            User u = Serialization.Deserialize<User>();
            Home h = Serialization.Deserialize<Home>();
            Car c = Serialization.Deserialize<Car>();

            Console.WriteLine($"User => {u.Name} | Home => {h.City} | Car => {c.Brand}");

            Console.ReadKey();

        }
    }
}
