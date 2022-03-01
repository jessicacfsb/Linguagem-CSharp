using System;
using System.Globalization;

namespace validacao_de_nota {
    class Program {
        static void Main(string[] args) {

            double nota1, nota2, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota1 < 0 || nota1 > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            while (nota2 < 0 || nota2 > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (nota1 + nota2) / 2;

            Console.Write("MEDIA = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
