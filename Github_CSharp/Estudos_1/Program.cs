using ExerciciosClasses;
using System;
using System.Globalization;

namespace Course {
    class ContaExercicio {
        static void Main(string[] args) {

            Console.Write("Entre o número da conta: ");
            string numConta = Console.ReadLine();

            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string haveraDepositoInicial = Console.ReadLine();

            Conta conta = new Conta(numConta, titularConta);

            double valorDeposito = 0.00;

            if (haveraDepositoInicial == "s" || haveraDepositoInicial == "S") {
                Console.Write("Entre o valor de depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Depositar(valorDeposito);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
