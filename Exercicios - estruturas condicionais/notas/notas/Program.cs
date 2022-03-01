using System;
using System.Globalization;

namespace notas {
    class Program {
        static void Main(string[] args) {

            double nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));
            if (media < 60.00) {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
