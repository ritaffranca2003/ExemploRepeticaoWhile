using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont = 0;
            double n1, n2;
            Console.WriteLine("Digite a quantidade de alunos para calcular a média");
            num = int.Parse(Console.ReadLine());
            while (cont < num)
            {
                Console.WriteLine("Digite a primeira nota");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota");
                n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Média=" + ((n1 + n2) /2) + "\n");
                cont++;
            }
            Console.ReadKey();

        }
    }
}
