using System.Globalization;

namespace ExerciciosClasses {
    internal class Conta {

        public string Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(string numero, string titular) { 
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public void Depositar (double valorDepositado) {

            Saldo += valorDepositado;
        }

        public void Sacar(double valorRetirado) {

            Saldo -= (valorRetirado + 5);
        }

        public override string ToString() {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
