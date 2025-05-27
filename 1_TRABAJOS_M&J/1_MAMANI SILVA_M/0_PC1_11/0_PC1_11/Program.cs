using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double varA, varB;
            double varPer, varArea, varDiag;

            Console.Write("dime el ancho de tu rectangulo :");
            varA = int.Parse(Console.ReadLine());
            Console.Write("dime la altura de tu rectangulo :");
            varB = int.Parse(Console.ReadLine());

            varPer = 2 * varA + 2 * varB;

            varArea = varA * varB;

            varDiag = Math.Sqrt(Math.Pow(varA, 2) + Math.Pow(varB, 2));

            Console.WriteLine("el resultado del perimetro de tu rectangulo es : " + varPer + "cm");
            Console.WriteLine("el resultado del area de tu rectangulo es : " + varArea + "cm2");
            Console.WriteLine("el resultado del diagonal de tu rectangulo es : " + varDiag + "cm");
            Console.ReadKey();
        }
    }
}
