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

            Console.WriteLine(" A soma é " + soma );

            Console.WriteLine(" Exercicio 2, favor vá teclando ENTER até a resolução ");
            for (int i = 0; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("fizz ");
                }
                if (i % 5 == 0)
                {
                    Console.Write("buzz ");
                }
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

                Console.ReadKey();

            }
        }
    }
}
