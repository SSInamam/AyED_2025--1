using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            Console.Write("Ingresa una cifra : ");
            nro = int.Parse(Console.ReadLine());

            for (int can = 0 + 1 ; can < nro +1; can++)
            {
                if (can % 2 == 0)
                {
                    Console.WriteLine(" " + can);
                }
                else
                {
                    Console.WriteLine(" impar ");
                }
                
            }

            Console.ReadKey();
        }
    }
}
