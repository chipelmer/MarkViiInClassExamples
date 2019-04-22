using System;
using System.Collections.Generic;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck a = new Truck();
            a.CabType = "Super";

            Console.WriteLine(a.BedSize);
        }
    }

    class Truck
    {
        public string CabType { get; set; }

        public int BedSize
        {
            get
            {
                if (CabType == "Single")
                    return totalTruckLength - 6;
                else if (CabType == "Double")
                    return totalTruckLength - 10;
                else if (CabType == "Super")
                    return totalTruckLength - 15;
                else
                    return totalTruckLength;
            }
        }

        private int totalTruckLength = 20;

        public int GetBedSize()
        {
            if (CabType == "Single")
            {
                return totalTruckLength - 6;
            }
            else if (CabType == "Double")
            {
                return totalTruckLength - 10;
            }
            else if (CabType == "Super")
            {
                return totalTruckLength - 15;
            }
            else
            {
                return totalTruckLength;
            }
        }
    }
}
