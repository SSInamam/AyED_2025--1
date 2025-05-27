using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int cifra1;
            int cifra2;
            int resul;

            Console.Write("ingrese un numero : ");
            cifra1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese un numero : ");
            cifra2 = int.Parse(Console.ReadLine());
            resul = cifra1 / cifra2;


            if(resul == 0)
            {

                Console.Write("ERROR");
            }
            else
            {
                Console.WriteLine("tu resultado es : " + resul);
            }

            Console.ReadKey();
        }
    }
}
