using System;

namespace soma_matrizes {
    class Program {
        static void Main(string[] args) {

            int linhas, colunas;

            Console.Write("Quantas linhas vai ter cada matriz? ");
            linhas = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter cada matriz? ");
            colunas = int.Parse(Console.ReadLine());

            int[,] matA = new int[linhas, colunas];
            int[,] matB = new int[colunas, colunas];
            int[,] matSoma = new int[linhas, colunas];

            Console.WriteLine("Digite os valores da matriz A: ");
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matA[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os valores da matriz B: ");
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("MATRIZ SOMA: ");
            for (int i = 0; i < linhas; i++) {
                Console.WriteLine("");
                for (int j = 0; j < colunas; j++) {
                    matSoma[i, j] = matA[i , j] + matB[i, j];
                    Console.Write(matSoma[i, j] + " ");
                }
            }

        }
    }
}
