using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine(" Saludos estimado usuario");
                Console.WriteLine(" ¿Que opcion desea elegir?");
                Console.WriteLine("\n===== MENÚ DE OPCIONES =====");
                Console.WriteLine(" Eleccion I, NUMERO PAR/IMPAR");
                Console.WriteLine(" Eleccion II, EDAD");
                Console.WriteLine(" Eleccion III, BROMA");
                Console.WriteLine(" Eleccion IV, VUELTA");
                Console.WriteLine(" Eleccion V, SALIR");

                Console.Write(" Ahora digame que elige : ");


                string eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    case "Eleccion I":
                        Console.Write(" Dime un numero par: ");
                        int num = int.Parse(Console.ReadLine());

                        if (num % 2 == 0)
                        {
                            Console.WriteLine(" CORRECTO, " + num + " si es numero par");
                        }
                        else
                        {
                            Console.WriteLine(" INCORRECTO, " + num + " es un numero impar");
                        }


                        break;


                    case "Eleccion II":
                        int edad;
                        Console.Write(" Dime el año en el que estamos : ");
                        int año = int.Parse(Console.ReadLine());

                        edad = 2025 - año;

                        Console.WriteLine(" la edad que tienes ahora : " + edad);
                        break;

                    case "Eleccion III":
                        string resp;
                        Console.WriteLine("....");
                        resp = Console.ReadLine();
                        while ( resp != "hola")
                        {
                            Console.WriteLine(".....");
                            resp = Console.ReadLine();
                        }
                        Console.WriteLine(" Jajaja, caiste. Tienes poca paciencia");
                        break;

                    case "Eleccion IV":
                        string sil1,sil2,sil3;

                        Console.Write("Ingrese una silaba : ");
                        sil1 = Console.ReadLine();
                        Console.Write("Ingrese otra silaba : ");
                        sil2 = Console.ReadLine();
                        Console.Write("Ingrese otra silaba : ");
                        sil3 = Console.ReadLine();

                        Console.WriteLine( " tu siguiente palabra es : " + sil2 + sil1 +sil3);
                        break;
           
                    case "Eleccion V":
                        Console.WriteLine(" Sin nada mas que decir, me despido");
                        salir = true;
                        break;


                    default:
                        Console.WriteLine("Respuesta invalida, vuelva a decir lo que va a pedir");
                        break;
                }

            } while (salir != true);

            Console.ReadLine();
            
        }
    }
}
