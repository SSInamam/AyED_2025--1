using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC1_5
{
    class Program
    {
        static void Main()
        {
            int hpHornet = 10;
            int hpMaxHornet = 10;
            int atkHornet = 3;
            int hpEnemigo = 12;
            Console.WriteLine("=== Hollow Knight: Simulador básico ===");
            while (hpHornet > 0 && hpEnemigo > 0)
            {
                MostrarEstado(hpHornet, hpEnemigo);
                Console.Write("\n Acción (atacar/curar/salir): ");
                string accion = Console.ReadLine();
                if (accion == "atacar")
                {
                    hpEnemigo = Atacar(atkHornet, hpEnemigo);
                }
                else if (accion == "curar")
                {
                    hpHornet = Curar(hpHornet, hpMaxHornet);
                }
                else if (accion == "salir")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(" Acción no válida.");
                
                }
                // Enemigo ataca automáticamente
                if (hpEnemigo > 0)
                {
                    hpHornet -= 2;
                    Console.WriteLine("\n El enemigo contraataca y hace 2 de daño!");
                }

                
            }
            Console.WriteLine("\n=== Resultado ===");
            if (hpHornet <= 0) Console.WriteLine(" Hornet ha caído...");
            else if (hpEnemigo <= 0) Console.WriteLine(" ¡Hornet ganó!");
            else Console.WriteLine(" Batalla interrumpida.");

            Console.ReadKey();
        }
        // -------------------
        // ACA DEBEN CREAR LAS FUNCIONES:
        // 1) Atacar
        // 2) Curar
        // 3) MostrarEstado
        static int Atacar(int atkHornet, int hpEnemigo)
        {
            int hpnuevo_enem = 0;
            
            Console.WriteLine(" ¡¡PAW!!");
            hpnuevo_enem = hpEnemigo - atkHornet;

            if (hpnuevo_enem > 0) Console.WriteLine(" El enemigo esta dañado. Su HP ahora es de: " + hpnuevo_enem);
            else Console.WriteLine(" El Enemigo ha sido derrotado."); 

            return hpnuevo_enem; 
        }
            
        static int Curar(int hpHornet, int hpMaxHornet)
        {
            int hpnuevo_hornt = 0;
            hpMaxHornet = 10;
            if (hpHornet >= hpMaxHornet)
            {
                Console.WriteLine(" Hornet tiene el HP completo no se puede aumentar mas.");
            }
            else
            {
                Console.WriteLine(" '++' '++' ");
                hpnuevo_hornt = hpHornet + 5;
                Console.WriteLine(" Curado. El HP de Hornet es de : " + hpnuevo_hornt);
            }
            return hpnuevo_hornt;
        }

        static void MostrarEstado(int hpHornet, int hpEnemigo)
        {
            Console.WriteLine(" ===== ESTADO DE HORNET Y EL ENEMIGO =====");
            Console.WriteLine(" HP de Hornet : " + hpHornet + "|" + " HP de Enemigo : "+ hpEnemigo);
        }

    }
}
