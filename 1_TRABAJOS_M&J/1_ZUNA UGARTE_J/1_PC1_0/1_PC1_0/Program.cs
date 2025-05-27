using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_0
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad;

            Console.Write("¿Cuantos años tienes ?:");
            edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine(" Entonces eres menor de edad");
            }

            else
            {
                Console.WriteLine(" Entonces seres mayor de edad");
            }

            Console.ReadKey();












        }
    }
}
