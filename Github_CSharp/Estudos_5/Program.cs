using System;
using System.Globalization;
using System.Collections.Generic;
using Estudos3.Entities.Enums;
using Estudos3.Entities;

namespace Course
{
    class ContaExercicio
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus> (Console.ReadLine());

            Console.Write("How many items to this order? ");
            int itemQuantity = int.Parse(Console.ReadLine());

            Product product;
            OrderItem item;
            Order order = new Order(status, client);

            for(int i = 0; i < itemQuantity; i++)
            {
                Console.WriteLine($"Enter #{(i + 1)} item data: ");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                item = new OrderItem(productQuantity, product);

                order.addItem(item);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}