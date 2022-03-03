using System;

namespace cada_linha {
    class Program {
        static void Main(string[] args) {

            int qtd, maior;

            Console.Write("Qual a ordem da matriz? ");
            qtd = int.Parse(Console.ReadLine());

            int[,] mat = new int[qtd, qtd];

            for (int i = 0; i < qtd; i++) {
                for (int j = 0; j < qtd; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA: ");
            for (int i = 0; i < qtd; i++) {
                maior = 0;
                for (int j = 0; j < qtd; j++) {
                    if (mat[i, j] > maior) {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }

        }
    }
}
