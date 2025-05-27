using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable1;
            int variable2;
            int VAR3;

            variable1 = int.Parse(Console.ReadLine());

            variable2 = int.Parse(Console.ReadLine());

            VAR3 = variable1 + variable2;

            Console.WriteLine("TU RESULTADO ES " + VAR3);

            Console.ReadKey();
        }
    }
}
