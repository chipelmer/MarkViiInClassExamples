using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace MarkViiInClassExamples
{
    class ProductRepository
    {
        private const string connStr = "YOUR CONNECTION STRING HERE";

        public void InsertProduct(Product product)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText =
                "INSERT INTO products (Name, Price, CategoryID, OnSale, StockLevel) " +
                $"VALUES (@productName, {product.Price}, 1, 0, 999);";
            cmd.Parameters.AddWithValue("productName", product.Name);

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int productId)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText =
                "DELETE FROM products " +
                $"WHERE ProductID={productId};";

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProductName(int productId, string newName)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText =
                "UPDATE products " +
                "SET Name=@name " +
                $"WHERE ProductID={productId};";
            cmd.Parameters.AddWithValue("name", newName);

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Product> GetAllProducts()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText =
                "SELECT ProductID, Name, Price " +
                "FROM products;";

            List<Product> products = new List<Product>();
            using (cmd.Connection)
            {
                cmd.Connection.Open();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read() == true)
                {
                    Product product = new Product();

                    product.Id = dataReader.GetInt32("ProductID");
                    product.Name = dataReader.GetString("Name");
                    product.Price = dataReader.GetDecimal("Price");

                    products.Add(product);
                }
            }

            return products;
        }
    }
}
