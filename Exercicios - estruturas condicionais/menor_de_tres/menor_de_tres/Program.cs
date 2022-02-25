using System;
using System.Globalization;

namespace menor_de_tres {
    class Program {
        static void Main(string[] args) {

            int valor1, valor2, valor3, menor;

            Console.WriteLine("Primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Segundo valor: ");
            valor2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor1 < valor2 && valor1 < valor3){
                menor = valor1;
            }
            else if (valor2 < valor1 && valor2 < valor3){
                menor = valor2;
            }
            else {
                menor = valor3;
            }

            Console.WriteLine("MENOR = " + menor);

        }
    }
}
