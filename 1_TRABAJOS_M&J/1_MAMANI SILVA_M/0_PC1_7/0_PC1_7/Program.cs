using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int varx;
            int vary;
            int varz;

            varx = int.Parse(Console.ReadLine());
            vary = int.Parse(Console.ReadLine());

            varz = varx / vary;

            Console.WriteLine("tu resultado es = " + varz);
            Console.ReadKey();


        }
    }
}
