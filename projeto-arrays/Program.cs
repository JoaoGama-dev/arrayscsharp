using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Arrays, resolução do exercício 1.");

            double[] numeros = new double[7];
            numeros[1] = 1;
            numeros[2] = 2;
            numeros[3] = 3;
            numeros[4] = 4;
            numeros[5] = 10;
            numeros[6] = 11;
            double soma = numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6];

            Console.WriteLine("Soma é " + soma , "tecle ENTER para sair...");
            Console.ReadKey();

        }
    }
}
