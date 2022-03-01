using System;

namespace quadrante {
    class Program {
        static void Main(string[] args) {

            int valor1, valor2;

            Console.WriteLine("Digite os valores das coordenadas X e Y: ");
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            while(valor1 != 0 && valor2 != 0) {
                if (valor1 > 0 && valor2 > 0) {
                    Console.WriteLine("QUADRANTE Q1");
                }
                else if (valor1 < 0 && valor2 > 0) {
                    Console.WriteLine("QUADRANTE Q2");
                }
                else if (valor1 < 0 && valor2 < 0) {
                    Console.WriteLine("QUADRANTE Q3");
                }
                else if (valor1 > 0 && valor2 < 0) {
                    Console.WriteLine("QUADRANTE Q4");
                }
                Console.WriteLine("Digite os valores das coordenadas X e Y: ");
                valor1 = int.Parse(Console.ReadLine());
                valor2 = int.Parse(Console.ReadLine());
            }
        }
    }
}
