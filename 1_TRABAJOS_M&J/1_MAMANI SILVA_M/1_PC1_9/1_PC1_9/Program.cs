using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int regres;

            Console.Write("Dime un numero para la cuenta regresiva : ");
            regres = int.Parse(Console.ReadLine());

            Console.WriteLine("La cuenta regresiva empieza en " + regres);

            for (int cin = regres - 1 ; cin > -1; cin--)
            {
                Console.WriteLine("La ceunta regresiva termina en " + cin);
            }

            Console.ReadLine();
        }
    }
}
