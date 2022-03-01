using System;
using System.Globalization;

namespace dardo {
    class Program {
        static void Main(string[] args) {

            double distancia1, distancia2, distancia3, maior;

            Console.WriteLine("Digite as tres distancias: ");
            distancia1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            distancia2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            distancia3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (distancia1 > distancia2 && distancia1 > distancia3){
                maior = distancia1;
            }
            else if (distancia2 > distancia1 && distancia2 > distancia3){
                maior = distancia2;
            }
            else {
                maior = distancia3;
            }

            Console.WriteLine("MAIOR DISTANCIA = " + maior.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
