using System;
using System.Globalization;

namespace programa_entarada_de_dados {
    class Program {
        static void Main(string[] args) {
            int idade;
            double salario;
            string nome;
            char sexo;

            idade = 32;
            salario = 4560.9;
            nome = "Maria Silva";
            sexo = 'f';

            Console.WriteLine("A funcionaria " + nome + ", sexo " + sexo +
                ", ganha " + salario.ToString("F2", CultureInfo.InvariantCulture) + 
                " e tem " + idade + " anos");
        }
    }
}
