using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string contra;

            Console.Write(" cual es tu contra?:");

            contra = Console.ReadLine();

            if (contra != "papiro" )
            {
                Console.WriteLine(" Contraseña incorrecta");
            }

            else
            {
                Console.WriteLine(" Contraseña correcta");
            }

            Console.ReadKey();











        }
    }
}
