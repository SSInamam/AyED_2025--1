using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;

            Console.Write(" ¿Deseas continuar con el programa? : ");
            resp = Console.ReadLine();

            while (resp != "SI")
            {
                Console.Write(" ¿Deseas continuar con el programa? : ");
                resp = Console.ReadLine();
            }
            Console.WriteLine("¡Hasta la vista!");

            Console.ReadKey();
        }
    }
}
