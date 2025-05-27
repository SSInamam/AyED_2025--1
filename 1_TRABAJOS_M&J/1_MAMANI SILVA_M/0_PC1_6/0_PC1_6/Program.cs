using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int VAR1;
            int VAR2;
            int VAR3;

            VAR1 = int.Parse(Console.ReadLine());
            VAR2 = int.Parse(Console.ReadLine());

            VAR3 = VAR1 * VAR2;

            Console.WriteLine("tu resutado es = " + VAR3);
            Console.ReadKey();


        }
    }
}
