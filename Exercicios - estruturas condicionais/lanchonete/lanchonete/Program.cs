using System;
using System.Globalization;

namespace lanchonete {
    class Program {
        static void Main(string[] args) {

            int cod, qtd;
            double valorTotal;

            Console.WriteLine("Codigo do produto comprado: ");
            cod = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade comprada: ");
            qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (cod == 1) {
                valorTotal = qtd * 5.00;
            }
            else if (cod == 2) {
                valorTotal = qtd * 3.50;
            }
            else if (cod == 3) {
                valorTotal = qtd * 4.80;
            }
            else if (cod == 4) {
                valorTotal = qtd * 8.90;
            }
            else {
                valorTotal = qtd * 7.32;
            }

            Console.WriteLine("Valor a pagar: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
