using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC1_0
{
    class Program
    {

        static string Conver(string saludo)
        {
            return "Hola "+ saludo +". Es un placer";
        }
        static void Main(string[] args)
        {
            Console.Write(" Muy Buenas, ¿ Cómo te llamas? : ");
            string Resp = Conver (Console.ReadLine());
            Console.WriteLine(Resp);

            Console.ReadKey();
        }
    }
}
