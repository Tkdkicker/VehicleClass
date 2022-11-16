using System;

namespace VehicleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first car is called:");
            Car descriptionCar1 = new();
            descriptionCar1.Description("Fer", "Convertable", "Red", "£60,000.00");

            Console.WriteLine("\nThe second car is called:");
            Car descriptionCar2 = new();
            descriptionCar2.Description("Jump", "Van", "Blue", "£10,000.00");
        }
    }
}