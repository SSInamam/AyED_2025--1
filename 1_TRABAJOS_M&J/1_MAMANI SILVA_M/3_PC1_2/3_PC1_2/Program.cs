using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;  
using System.Text; 
using System.Threading.Tasks;

class program 
{
    static int rest(int num_x, int num_y)
    {
        return num_x - num_y;
    }

    static int sum(int num_x, int num_y)
    {
        return num_x + num_y;
    }

    static int mult(int num_x, int num_y)
    {
        return num_x * num_y;
    }

    static int divs(int num_x, int num_y)
    {
        return num_x / num_y;
    }

    static void Calculadora(int x, int y)
    {
        int res;
        int opc;
        bool salir = true;
        opc = int.Parse(Console.ReadLine());
        do
        {
            switch (opc)
            {
                case 1:
                    res = rest(x, y);
                    Console.Write("\n RESTA : " + res); ;
                    break;

                case 2:
                    res = sum(x, y);
                    Console.Write("\n SUMA : " + res);
                    break;

                case 3:
                    res = mult(x, y);
                    Console.Write("\n MULTIPLICACIÓN : " + res);
                    break;

                case 4:
                    res = divs(x, y);
                    Console.Write("\n DIVISIÓN : " + res);
                    break;

                default:
                    Console.WriteLine("\n Error. Intenta de nuevo");
                    break;
            }
        } while (salir != true);
    }

    static void Main(string[] args)
    {
        int numx = 0;
        int numy = 0;
        Console.Write(" Ingresa un valor : ");
        numx = int.Parse(Console.ReadLine());
        Console.Write(" Ingresa segundo valor : ");
        numy = int.Parse(Console.ReadLine());

        Console.WriteLine("\n === CALCULADORA ===");
        Console.Write(" 1.RESTA \n 2.SUMA \n 3.MULTIPLICACIÓN \n 4.DIVISIÓN \n Elige una opción : ");
        
        Calculadora(numx, numy);
        Console.ReadKey();
    }
}