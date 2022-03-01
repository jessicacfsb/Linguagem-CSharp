using System;

namespace diagonal_negativos {
    class Program {
        static void Main(string[] args) {

            int n, cont;

            Console.WriteLine("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            cont = 0;
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        Console.WriteLine(mat[i, j]);
                        cont = cont + 1;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);
        }
    }
}
