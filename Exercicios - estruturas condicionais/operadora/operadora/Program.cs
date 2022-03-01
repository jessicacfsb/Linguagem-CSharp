using System;
using System.Globalization;

namespace operadora {
    class Program {
        static void Main(string[] args) {

            int minutos, extras;
            double valor;

            Console.WriteLine("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (minutos <= 100) {
                valor = 50;
            }
            else {
                extras = minutos % 100;
                valor = 50 + (extras * 2);
            }

            Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
