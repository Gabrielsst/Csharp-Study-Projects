using Estudos4.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class ContaExercicio
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                string characteristics = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if ( characteristics == "u" )
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(data, name, price));
                }
                else if ( characteristics == "i" )
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(customsFee, name, price));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in list)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}