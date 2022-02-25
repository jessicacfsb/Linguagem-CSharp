using System;
using System.Globalization;

namespace idades {
    class Program {
        static void Main(string[] args) {

            string nome1, nome2;
            int idade1, idade2;
            double mediaIdades;

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            mediaIdades = ((double)idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + mediaIdades.ToString(("F1"), CultureInfo.InvariantCulture) + " anos ");
        }
    }
}
