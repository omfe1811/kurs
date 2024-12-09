using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Authentication;
using System.Security.Cryptography;

namespace oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crete a person istance
            Person person = new Person()
            {
                Name = "Olga",
                Age = 26,
                City = "Oslo"
            };
            person.SetMethod("jane");
            System.Console.WriteLine(person.Age);
            System.Console.WriteLine("-----------" + person.Name);
            System.Console.WriteLine(person.City);

            Animal animal = new Animal()
            {
                Name = "Cat",
                Legs = 4,
                Environment = "house"
            };

            animal.AnimalInfo();

            Car car = new()
            {
                Brand = "BMW",
                Color = "green",
                Year = 1998,
            };

            car.CarInfo();
            car.IsCarOld();
        }

    }
}
