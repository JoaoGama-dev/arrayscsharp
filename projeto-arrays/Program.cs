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
            /*
             * Vou te devolver o código com os comentários abaixo e solicitar algumas melhorias
             * 1 - Eu mandei um terceiro exercício para ser resolvido o ticket só vai ser dado como concluido quando tu resolver ele
             *
             * 2 - Cada um desses exercícios quero eles desenvolvidos em uma classe separada, por exemplo,
             * o exercicio de soma do Array quero em uma classe chamada SomaArray e o Fizz Buzz em uma classe com esse nome (pode dar teus proprios nomes para as classes)
             *
             * 3 - atente-se aos comentários logo abaixo por conta de pequenas melhorias que podem ser feitas
             *
             * 4 - Teu prazo para apresentar o projeto com as correções é até 19/09/20
             */
            Console.WriteLine("Criando Arrays, resolução do exercício 1.");

            double[] numeros = new double[7];
            // array sempre começa em zero
            numeros[1] = 1;
            numeros[2] = 2;
            numeros[3] = 3;
            numeros[4] = 4;
            numeros[5] = 10;
            numeros[6] = 11;

            // a soma tem outra forma de fazer, imagina se tu precisa somar 100 elementos de um array?
            double soma = numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6];

            Console.WriteLine(" A soma é " + soma);

            Console.WriteLine(" Exercicio 2, favor vá teclando ENTER até a resolução ");
            for (int i = 0; i < 100; i++)
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

                Console.ReadKey();// Esse carinha aqui não precisava estar aqui poderia ser rodado fora do for

            }

            // eu tinha pedido um terceiro exercício cade ele?
        }
    }
}
