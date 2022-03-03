using System;
using System.Globalization;

namespace soma_vetores {
    class Program {
        static void Main(string[] args) {

            int n;
            double soma, media;

            Console.WriteLine("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] valores = new double[n];

            soma = 0;
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite um numero: ");
                valores[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma = soma + valores[i];
            }

            Console.Write("VALORES = ");
            for (int i = 0; i < n; i++) {
                Console.Write(valores[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            Console.WriteLine("SOMA = " + soma.ToString("F2", CultureInfo.InvariantCulture));

            media = soma / n;
            Console.WriteLine("MEDIA = " + media.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
