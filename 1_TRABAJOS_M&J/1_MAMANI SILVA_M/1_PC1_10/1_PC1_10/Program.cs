using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Numeros desde el 1 hasta 100 ");

            for (int can = 0; can < 101; can++)
            {
                if (can % 3 == 0 && can % 5 != 0)

                {
                    Console.WriteLine(" Fizz");
                }
                else if (can % 3 != 0 && can % 5 != 0)
                {
                    Console.WriteLine(" " + can);
                }
                else if(can % 3 == 0 && can % 5 == 0)
                {
                    Console.WriteLine(" FizzBuzz");
                }
                else

                {
                    Console.WriteLine(" Buzz");
                }
            }

            Console.ReadKey();

            
        }
    }
}
