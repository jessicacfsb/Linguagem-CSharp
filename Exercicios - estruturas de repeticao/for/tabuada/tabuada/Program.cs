using System;
using System.Globalization;

namespace tabuada {
    class Program {
        static void Main(string[] args) {

            int valor, i, resultado;

            Console.Write("Deseja a tabuada para qual valor? ");
            valor = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++) {
                resultado = valor * i;
                Console.WriteLine(valor + "x " + i + " = " + resultado) ;
            }
        }
    }
}
