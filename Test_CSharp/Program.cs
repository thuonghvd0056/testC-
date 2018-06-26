using System;
using System.Collections.Generic;

namespace Test_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();
        }
        private static Product product = new Product();
        private static List<Product> list = new List<Product>()
        {
            new Product("MN001", "Monitor", "$38"),
            new Product("C01022", "CPU", "$94")
            
        };

        //1. Add product records.
        private static void AddProduct()
        {
            
            Console.WriteLine("please enter product id:");
            product.ProductId = Console.ReadLine();
            Console.WriteLine("please enter product name:");
            product.Name = Console.ReadLine();
            Console.WriteLine("please enter product price:");
            product.Price = Console.ReadLine();
            list.Add(product);
        }
        
        //2. Display product records.
        private static void DisplayProduct()
        {
            Console.WriteLine("{0, -20} {1, -20} {1, -20}", "ProductId", "Name", "Price");
            Console.WriteLine("---------------------------------------------------------");
            foreach (var product in list)
            {
                Console.WriteLine("{0, -20} {1, -20} {1, -20}", product.ProductId, product.Name, product.Price);
            }

            Console.ReadLine();
        }

        //3. Delete product by id.
        private static void Delete()
        {
            Console.WriteLine("please enter product id:");
            string productId = Console.ReadLine();
            Product delete = list.Find(a => a.ProductId == productId);
            list.Remove(delete);
        }
        
        private static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("--------------PRODUCT------------");
                Console.WriteLine("1. Add product records.");
                Console.WriteLine("2. Display product records.");
                Console.WriteLine("3. Delete product by id.");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Please enter your choice:");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                        case 1:
                            AddProduct();
                            Console.WriteLine("Success");
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 2:
                            DisplayProduct();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 3:
                            Delete();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 4:
                            Environment.Exit(1);
                            break;
                }
            }
        }
    }
}