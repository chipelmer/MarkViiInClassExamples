using System;
using System.Linq;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Marker blue = new Marker();
            blue.Brand = "Expo";
            blue.Color = "BLUE";
            blue.CapIsOn = true;

            Marker green = new Marker();
            green.Brand = "Expo";
            green.Color = "green";
            green.CapIsOn = false;

            WriteWithMarker(blue);
            WriteWithMarker(green);
        }

        static void WriteWithMarker(Marker marker)
        {
            if (marker.CapIsOn)
            {
                Console.WriteLine("Take cap off");
            }

            Console.WriteLine($"Writing with a {marker.Color} {marker.Brand} marker.");
        }
    }

    class ClassWithFourWords
    {

    }
}
