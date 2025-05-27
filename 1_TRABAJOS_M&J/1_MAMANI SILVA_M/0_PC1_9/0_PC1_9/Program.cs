using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double varA;
            double varb;
            double varsuper;
            double varvolum;

            varA = int.Parse(Console.ReadLine());

            varsuper = 4 * Math.PI * Math.Pow(varA, 2);



            Console.WriteLine("LA SUPERFICIE DE TU ESFERA ES : " + varsuper);

            varb = int.Parse(Console.ReadLine());

            varvolum = Math.PI * Math.Pow(varb, 3) * 4/3;

            Console.WriteLine("LA VOLUMEN DE TU ESFERA ES : " + varvolum);


            Console.ReadKey();




        }
    }
}
