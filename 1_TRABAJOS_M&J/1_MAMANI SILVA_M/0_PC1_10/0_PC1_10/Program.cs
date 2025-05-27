using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int varcelc;
            int varkelv;
            int varfahren;

            varcelc = int.Parse(Console.ReadLine());

            varkelv = 273 + 100 * varcelc / 100;

            varfahren = 32 + 180 * varcelc / 100;

            Console.WriteLine(varcelc +"°C en grados Kelvin seria : " + varkelv);
            Console.WriteLine( varcelc + "°C en grados Fahrenheit seria : " + varfahren);
            Console.ReadKey();


        }
    }
}
