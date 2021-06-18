using System;

namespace Avaliação_Prática
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avaliação Prática para as disciplinas de Desenvolvimento Multiplataforma e Desenvolvimento Colaborativo!\n");

            Console.WriteLine("Digite o valor de A");
            var A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            var B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            var C = int.Parse(Console.ReadLine());

            var bhaskara = new Bhaskara();

            Console.WriteLine("Resultado: " + bhaskara.CalcularBhaskara(A, B, C));
        }
    }
}
