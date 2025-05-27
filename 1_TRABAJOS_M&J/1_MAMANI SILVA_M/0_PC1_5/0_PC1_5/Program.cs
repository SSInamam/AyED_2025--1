using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1;
            int var2;
            int var3;

            var1 = int.Parse(Console.ReadLine());
            var2 = int.Parse(Console.ReadLine());

            var3 = var1 - var2;

            Console.WriteLine("tu resultado es = " + var3);
            Console.ReadKey();

        }
    }
}
