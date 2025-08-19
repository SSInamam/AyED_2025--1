using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC1_1
{
    class Program
    {
        static int valz(int valx, int valy)
        {
            return valx + valy;

        }
        static void Main(string[] args)
        {
            Console.Write(" Dame dos valores : ");
            int valfin = valz(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(" La suma de los valores es : " + valfin);
            Console.ReadKey();
        }
    }
}
