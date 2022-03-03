using System;

namespace soma_vetores {
    class Program {
        static void Main(string[] args) {

            int qtd;

            Console.Write("Quantos valores vai ter cada vetor? ");
            qtd = int.Parse(Console.ReadLine());

            int[] vet1 = new int[qtd];
            int[] vet2 = new int[qtd];
            int[] vetResultante = new int[qtd];

            Console.WriteLine("Digite os valores do vetor A: ");
            for (int i=0; i < qtd; i++) {
                vet1[i] = int.Parse(Console.ReadLine());
            }    

            Console.WriteLine("Digite os valores do vetor B: ");
            for (int j = 0; j < qtd; j++) {
                vet2[j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("VETOR RESULTANTE: ");
            for (int i = 0; i < qtd; i++) {
                vetResultante[i] = vet1[i] + vet2[i];
                Console.WriteLine(vetResultante[i]);
            }
        }
    }
}
