using System;
using System.Collections.Generic;
using System.Linq;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            ProductRepository repo = new ProductRepository();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1) View Products");
                Console.WriteLine("2) Insert Product");
                Console.WriteLine("3) Update Product");
                Console.WriteLine("4) Delete Product");
                Console.WriteLine("5) Exit");

                string response = Console.ReadLine();
                Console.Clear();

                if (response == "1")
                    UI.ViewProducts(repo);
                else if (response == "2")
                    UI.InsertNewProduct(repo);
                else if (response == "3")
                    UI.UpdateExistingProduct(repo);
                else if (response == "4")
                    UI.DeleteProduct(repo);
                else if (response == "5")
                    break;
                else
                    Console.WriteLine("Response not recognized.");
            }
        }
    }
}
