using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero, resultado, i;

            Console.WriteLine("Digite o numero de 1a 10 do qual você deseje saber a tabuada:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 10)
            {
                for (i = 1; i < 11; i++)
                {
                    resultado = i * numero;
                    Console.WriteLine("{0} X {1} = {2}", i, numero, resultado);

                }
            }
            else
            {
                Console.WriteLine("Ops! Valor digitar um valor de 1 a 10...");
            }
         
        }
    }
}
