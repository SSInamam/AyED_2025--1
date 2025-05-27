using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string refug, comida, bate;

            Console.Write("¿Usted tiene un refugio? : ");
            refug = Console.ReadLine();
            Console.Write("¿Posee un bate? : ");
            bate = Console.ReadLine();
            Console.Write("¿Y tiene comida? : ");
            comida = Console.ReadLine();

            if (refug == "si" && bate == "si" && comida == "si")
            {
                Console.WriteLine("afortunadamente usted podra sobrevivir");
            }
            else
            {
                Console.WriteLine("lamentablemente usted no podra sobrevivir");
            }
            Console.ReadKey();
        }
    }
}
