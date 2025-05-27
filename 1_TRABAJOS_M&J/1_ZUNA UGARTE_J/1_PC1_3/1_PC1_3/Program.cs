using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int cifra;

            Console.Write(" ingrese un numerto :");
            cifra = int.Parse(Console.ReadLine());

            if (cifra % 2 == 1)
            {
                Console.WriteLine(cifra + "  tu numero es impar");

            }
            else if (cifra == 0)
            {
                Console.WriteLine(" tu numero es nulo ");
            }

            else
            {
                Console.WriteLine(cifra + "  tu numero es par"); 
            }
            Console.ReadKey();
        }
    }
}
