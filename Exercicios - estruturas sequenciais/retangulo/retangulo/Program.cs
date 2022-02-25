using System;
using System.Globalization;

namespace retangulo {
    class Program {
        static void Main(string[] args) {

            double altura, largura, area, perimetro, diagonal;

            Console.WriteLine("Base do retangulo: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Altura do retangulo: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * altura;
            perimetro = 2 * (largura + altura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }

    }
}
