using Estudos1;
using System;
using System.Globalization;

namespace Course {
    class ContaExercicio {
        static void Main(string[] args) {

            Quartos[] cliente = new Quartos[10];

            Console.Write("How many rooms will be rented? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++) {
                Console.WriteLine();
                Console.WriteLine("Rent #{0}:", i + 1);

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                while (cliente[room]?.Name != null) {
                    Console.Write("Room: ");
                    room = int.Parse(Console.ReadLine());
                }

                cliente[room] = new Quartos(name, email, room);
            }

            Console.WriteLine();
            Console.WriteLine("Busy Rooms:");
            for (int i = 0;i < 10;i++) { 
                if (cliente[i]?.Name != null) {
                    Console.WriteLine(cliente[i]);
                }
            }
        }
    }
}