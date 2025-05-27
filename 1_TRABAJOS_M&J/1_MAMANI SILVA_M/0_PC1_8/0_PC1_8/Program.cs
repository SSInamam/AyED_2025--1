using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int varI;
            int varII;
            int varRESTO;

            varI = int.Parse(Console.ReadLine());
            varII = int.Parse(Console.ReadLine());

            varRESTO = varI % varII;

            Console.WriteLine("el resto del resultado es : " + varRESTO);
            Console.ReadKey();


        }
    }
}
