using System;

namespace negativos_matriz {
    class Program {
        static void Main(string[] args) {

            int linhas, colunas, negativos;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            linhas = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz?");
            colunas = int.Parse(Console.ReadLine());

            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    Console.Write("Elemento[" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("VALORES NEGATIVOS: ");
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    if (mat[i, j] < 0) {
                        negativos = mat[i,j];
                        Console.WriteLine(negativos);
                    }
                }
            }

            
        }
    }
}
