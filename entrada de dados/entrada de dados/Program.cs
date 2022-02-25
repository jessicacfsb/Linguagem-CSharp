using System;
using System.Globalization;

namespace entrada_de_dados {
    class Program {
        static void Main(string[] args) {

            int x, y;
            double x1;

            x = 10;
            y = 20;
            x1 = 2.0;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x1.ToString("F2" , CultureInfo.InvariantCulture));
        }
    }
}
