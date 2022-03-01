using System;

namespace dentro_fora {
    class Program {
        static void Main(string[] args) {

            int qtd, numero, dentro, fora;

            Console.Write("Quantos numeros voce vai digitar? ");
            qtd = int.Parse(Console.ReadLine());

            dentro = 0;
            fora = 0;
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 10 && numero <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " DENTRO");
            Console.WriteLine(fora + " FORA");
        }
    }
}
