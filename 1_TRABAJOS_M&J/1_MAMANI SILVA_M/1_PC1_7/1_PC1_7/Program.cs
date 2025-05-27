using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string palab;

            Console.Write("Digame una palabra : ");
            palab = Console.ReadLine();

            for (int can = 0; can < 11; can++)
            {
                Console.WriteLine(palab);
            }

            Console.ReadKey();
        }
    }
}
