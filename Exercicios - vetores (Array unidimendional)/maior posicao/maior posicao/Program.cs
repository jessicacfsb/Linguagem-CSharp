using System;
using System.Globalization;

namespace maior_posicao {
    class Program {
        static void Main(string[] args) {

            int qtd;
            double maior, posicao;

            Console.Write("Quanto numeros voce vai digitar? ");
            qtd = int.Parse(Console.ReadLine());

            double[] vet = new double[qtd];
            for (int i = 0; i < qtd; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            maior = 0;
            posicao = 0;
            for (int i = 0; i < qtd; i++) {
                if (vet[i] > maior) {
                    maior = vet[i];
                    posicao = i;
                }
            }

            Console.Write("\nMAIOR VALOR = " + maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.Write("\nPOSICAO DO MAIOR VALOR = " + posicao);
        }
    }
}
