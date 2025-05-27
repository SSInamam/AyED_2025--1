using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC__3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un código en el que almacenemos el nombre en una variable 'nombre' y la edad en la variable 'edad'  Los datos deben ser ingresados por el usuariosFinalmente debe saludar "Hola NOMBRE , tu edad es EDAD".
            string nombre;
            int edad;

            Console.Write("cual es tu nombre :");

            nombre = Console.ReadLine();

            edad = int.Parse(Console.ReadLine());
            Console.Write("cual es tu edad :");
            Console.WriteLine("hola mundo " + nombre + " tuedad es " + edad);

            Console.WriteLine("tu nombre es " + nombre);

            Console.ReadKey();

        }
    }
}
