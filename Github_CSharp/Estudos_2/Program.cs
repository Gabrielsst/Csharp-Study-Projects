using ExerciciosAvançados;
using System;
using System.Globalization;

namespace Course {
    class ContaExercicio {
        static void Main(string[] args) {

            Console.Write("Length of the array: ");
            int N = int.Parse(Console.ReadLine());
            
            Product[] products = new Product[N];

            for (int i = 0;i < N; i++) {

                Console.Write("name of the product {0}: ", i + 1);
                string name = Console.ReadLine();

                Console.Write("price of the product {0}: ", i + 1);
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                products[i] = new Product(name, price);
            }

            double sum = 0;
            for (int i = 0;i < N; i++) {
                sum += products[i].Price;
            }

            double avg = sum / N;

            Console.WriteLine("AVERAGE PRICE = {0}", avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
