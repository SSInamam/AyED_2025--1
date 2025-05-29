using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;

            Random rand = new Random();

            while (sigueVivo && dia <= 7)
            {
                Console.Clear();
                Console.WriteLine($"🌴 Día {dia} – ¿Qué querés hacer?");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego");
                Console.Write("Elija una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\nBuscás comida...");
                        hambre += 20;
                        energia -= 15;
                        int probComidaMala = rand.Next(1, 101);
                        if (probComidaMala <= 30)
                        {
                            salud -= 15;
                            Console.WriteLine("🍽️ Comiste algo en mal estado. Salud -15.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\nDormís para recuperar energía...");
                        energia += 30;
                        hambre -= 10;
                        break;

                    case "3":
                        Console.WriteLine("\nExplorás la isla...");
                        energia -= 20;
                        hambre -= 15;
                        int probPlanta = rand.Next(1, 101);
                        if (probPlanta <= 50)
                        {
                            salud += 10;
                            Console.WriteLine("🌿 ¡Encontraste una planta curativa! Salud +10.");
                        }
                        break;

                    case "4":
                        Console.WriteLine($"\n📊 Estado actual:");
                        Console.WriteLine($"Salud: {salud}");
                        Console.WriteLine($"Hambre: {hambre}");
                        Console.WriteLine($"Energía: {energia}");
                        Console.WriteLine($"Día: {dia}");
                        Console.WriteLine("Presioná una tecla para continuar...");
                        Console.ReadKey();
                        continue;

                    case "5":
                        Console.WriteLine("\nSaliste del juego. ¡Hasta la próxima!");
                        sigueVivo = false;
                        continue;

                    default:
                        Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                        Console.ReadKey();
                        continue;
                }

                if (salud <= 0 || hambre <= 0 || energia <= 0)
                {
                    Console.WriteLine("\n☠️ Te desmayaste y no pudiste sobrevivir... Game Over.");
                    sigueVivo = false;
                }
                else
                {
                    dia++;
                    Console.WriteLine("\nPasaste el día. Presioná una tecla para continuar al siguiente...");
                    Console.ReadKey();
                }
            }

            if (sigueVivo)
            {
                Console.WriteLine("\n🎉 ¡Sobreviviste una semana en la isla! ¡Felicidades!");
            }
        }
    }
}
