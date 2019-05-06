using System;
using System.Collections.Generic;
using System.Text;

namespace MarkViiInClassExamples
{
    static class UI
    {
        public static void InsertNewProduct(ProductRepository repo)
        {
            Console.WriteLine("Let's insert a product.");

            Product product = new Product();

            Console.WriteLine("What is the name of the product?");
            product.Name = Console.ReadLine();

            Console.WriteLine("What is the price of the product?");
            product.Price = decimal.Parse(Console.ReadLine());

            repo.InsertProduct(product);
            Console.WriteLine("Product inserted.");
            Console.WriteLine();
        }

        public static void UpdateExistingProduct(ProductRepository repo)
        {
            Console.WriteLine("Let's change a product's name.");

            Console.WriteLine("What is the ID of the product to change?");
            int updateProductId = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the new name for the product?");
            string newName = Console.ReadLine();

            repo.UpdateProductName(updateProductId, newName);
            Console.WriteLine("Product name updated.");
            Console.WriteLine();
        }

        public static void DeleteProduct(ProductRepository repo)
        {
            Console.WriteLine("Let's delete a product.");

            Console.WriteLine("What is the ID of the product to delete?");
            int deleteProductId = int.Parse(Console.ReadLine());

            repo.DeleteProduct(deleteProductId);
            Console.WriteLine("Product deleted.");
            Console.WriteLine();
        }

        public static void ViewProducts(ProductRepository repo)
        {
            List<Product> products = repo.GetAllProducts();

            foreach (Product p in products)
            {
                Console.WriteLine(p.Id + " | " + p.Name + " | " + p.Price);
            }

            Console.WriteLine();
        }
    }
}
