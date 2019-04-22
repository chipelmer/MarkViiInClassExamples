using System;
using System.Collections.Generic;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck a = new Truck();
            Car b = new Car();
            Motorcycle c = new Motorcycle();

            Add100ToMileage(a);
            Add100ToMileage(b);
            Add100ToMileage(c);
        }

        static int Add100ToMileage(Vehicle vehicle)
        {
            return vehicle.Mileage + 100;
        }
    }

    class Vehicle
    {
        public string Model { get; set; }
        public int Mileage { get; set; }
    }

    class Car : Vehicle
    {
        public void Honk()
        {
            Console.WriteLine("Beep! Beep!");
        }
    }

    class Truck : Vehicle
    {
        public void RevEngine()
        {
            Console.WriteLine("Vrooom!");
        }
    }

    class Motorcycle : Vehicle
    {
        public void PopWheelie()
        {
            Console.WriteLine("Check it out!");
        }
    }
}
