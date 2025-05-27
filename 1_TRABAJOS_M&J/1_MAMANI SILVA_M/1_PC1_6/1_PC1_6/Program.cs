using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ciftemp;

            Console.Write("Dime la temperatu del agua : ");
            ciftemp = int.Parse(Console.ReadLine());

            if ( ciftemp > 100 )
            {
                Console.WriteLine("El agua esta hirbiendo");
            }
            else if (ciftemp >= 1 && ciftemp <= 99)
            {
                Console.WriteLine("El agua sigue en estado liquido");
            }
            else
            {
                Console.WriteLine("El agua se esta congelando");
            }

            Console.ReadKey();
        }
    }
}
