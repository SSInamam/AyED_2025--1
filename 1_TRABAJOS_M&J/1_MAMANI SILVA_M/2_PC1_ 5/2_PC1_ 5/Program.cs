using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC1__5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            Console.Write(" Ingrese la cantidad de los elementos que hay : ");
            valor = int.Parse(Console.ReadLine());

            int[] element = new int[valor];

            int valormini = 0;

            Console.Write(" Dime el valor minimo de los productos : ");
            valormini = int.Parse(Console.ReadLine());

            for (int can = 0; can < valor; can++)
            {
                Console.Write(" ingrese el valor del elemento [" + (can + 1) + "] : ");

                element[can] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("");

            for (int con = 0; con < valor; con++)
            {
                if (element[con] > valormini)
                {

                    Console.WriteLine((con +1) + " " + element[con]);
                }
            }

            Console.ReadKey();
        }
    }
}
