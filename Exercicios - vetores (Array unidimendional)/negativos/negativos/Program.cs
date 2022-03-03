using System;
using System.Globalization;

namespace negativos {
    class Program {
        static void Main(string[] args) {

            int qtd;

            Console.Write("Quantos numeros voce vai digitar? ");
            qtd = int.Parse(Console.ReadLine());

            int[] vet = new int[qtd];

            for (int i = 0; i < qtd; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NUMEROS NEGATIVOS: ");
            for (int i = 0; i < qtd; i++) {
                if (vet[i] < 0) {
                    Console.WriteLine(vet[i]);
                }
            }

        }
    }
}
