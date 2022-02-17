using System;

namespace Singleton_Design_Pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Functions functions = new Functions();
            try
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("1 - Add Car");
                Console.WriteLine("2 - List Car");
                Console.WriteLine("3 - Exit application");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        functions.AddCars();
                    break;
                    case 2:
                        functions.ListCars();
                    break;
                    case 3:
                        Console.WriteLine("Thanks for using the App.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter a number in the range of 1-3...");
                        Console.ReadKey();
                        Program.Main(args);
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a number in the range of 1-3...");
                Console.ReadKey();
                Program.Main(args);
            }
        }
    }
}
