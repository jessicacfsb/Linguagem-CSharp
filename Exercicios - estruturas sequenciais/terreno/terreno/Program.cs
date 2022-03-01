using System;
using System.Globalization;

namespace terreno {
    class Program {
        static void Main(string[] args) {

            double largura, comprimento, valor, area, preco;

            Console.WriteLine("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do metro quadrado: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * valor;

            Console.WriteLine("Area do terreno = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preco do terreno = " + preco.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
