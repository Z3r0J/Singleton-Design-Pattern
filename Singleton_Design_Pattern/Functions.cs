using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Design_Pattern
{
    public class Functions
    {
        CarsClass cars = new CarsClass();
        public void AddCars()
        {
            try
            {
                if (Singleton.instance.Cars.Count<40)
                {
                    Console.WriteLine("Please insert the brand: ");
                    cars.Brand = Console.ReadLine();
                    Console.WriteLine("Please insert the Year (Only Number): ");
                    cars.Year = Convert.ToInt32(Console.ReadLine());
                    Singleton.instance.Cars.Add(cars);

                    Console.WriteLine("The cars was add correctly, please press enter to come back...");
                    Console.ReadKey();
                    Console.Clear();
                    string[] args = { };
                    Program.Main(args);
                }
                else
                {
                    Console.WriteLine("You can only have a list of 40 cars.");
                    Console.ReadKey();
                    Console.Clear();
                    AddCars();

                }

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Oops, has occurred an error. please check you input.");
                Console.ReadKey();
                Console.Clear();
                AddCars();
            }
        }

        public void ListCars() {
            foreach (var item in Singleton.instance.Cars)
            {
                Console.WriteLine($"The brand is: {item.Brand} and The year is: {item.Year}");
            }
            Console.WriteLine("Press enter to go back...");
            Console.ReadKey();
            Console.Clear();
            string[] args = { };
            Program.Main(args);
        }
    }
}
