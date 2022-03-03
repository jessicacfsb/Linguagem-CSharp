using System;

namespace numeros_pares {
    class Program {
        static void Main(string[] args) {

            int qtd, par, cont;

            Console.Write("Quantos numeros voce vai digitar? ");
            qtd = int.Parse(Console.ReadLine());

            cont = 0;
            int[] vet = new int[qtd];
            for (int i = 0; i < qtd; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("\nNUMEROS PARES: ");
            for (int i = 0; i < qtd; i++) {
                if (vet[i] % 2 == 0) {
                    Console.Write(vet[i] + " ");
                    cont++;
                }
            }

            Console.Write("\n\nQUANTIDADE DE PARES = " + cont);
        }
    }
}
