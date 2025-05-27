using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, año;

            Console.Write(" Dime cuantos años tienes : ");
            edad = int.Parse(Console.ReadLine());
            Console.Write(" Y dime  que año naciste : ");
            año = int.Parse(Console.ReadLine());


            for (int con = edad - 17 , con1 = año  ; con < 18 && con1 > 2007 ; con ++ , con1 ++)
            {
                Console.WriteLine(" Entonces  tuviste " + con + " años en el " + con1);
            }

            Console.ReadKey();
        }
    }
}
