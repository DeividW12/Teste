using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro valor");

            int y = int.Parse(Console.ReadLine());

            int soma = x + y;

            Console.WriteLine("A soma dos valores {0} e {1} é: {2}", x, y, soma);

            Console.WriteLine("Digite um valor para multiplcar a soma");

            int mult = int.Parse(Console.ReadLine());

            Console.WriteLine("A multiplicação da soma é: {0} ", soma * mult);

            Console.ReadLine();
        }
    }
}
