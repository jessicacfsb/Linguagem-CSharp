using System;

namespace sequencia_impares {
    class Program {
        static void Main(string[] args) {

            int valor, i;

            Console.Write("Digite o valor de X: ");
            valor = int.Parse(Console.ReadLine());

            for (i = 1; i < valor; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
