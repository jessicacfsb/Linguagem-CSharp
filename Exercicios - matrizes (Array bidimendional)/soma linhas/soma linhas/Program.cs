using System;
using System.Globalization;

namespace soma_linhas {
    class Program {
        static void Main(string[] args) {

            int linhas, colunas;
            double soma;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            linhas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual a quantidade de colunas da matriz? ");
            colunas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[,] mat = new double[linhas, colunas];
            double[] vet = new double[linhas];

            for (int i = 0; i < linhas; i++) {
                Console.WriteLine("Digite os elementos da " + (i + 1) + "a. linha: ");
                for (int j = 0; j < colunas; j++) {
                    mat[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < linhas; i++) {
                soma = 0;
                for (int j = 0; j < colunas; j++) {
                    soma = soma + mat[i, j];
                }
                vet[i] = soma;
            }

            Console.WriteLine("VETOR GERADO: ");
            for (int i = 0; i < linhas; i++) {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
