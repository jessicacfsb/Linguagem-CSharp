using System;
using System.Globalization;

namespace media_idades {
    class Program {
        static void Main(string[] args) {

            int idades, soma, cont;
            double media;

            Console.WriteLine("Digite as idades: ");
            idades = int.Parse(Console.ReadLine());

            if (idades < 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {
                soma = 0;
                cont = 0;
                while (idades > 0) {
                    soma = soma + idades;
                    cont++;
                    idades = int.Parse(Console.ReadLine());
                }

                media = (double)soma / cont;
                Console.WriteLine("MEDIA = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
