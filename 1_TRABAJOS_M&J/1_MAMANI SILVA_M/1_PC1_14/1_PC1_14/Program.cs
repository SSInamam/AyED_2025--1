string nombre = "Jugador1";
int salud = 100;
int monedas = 50;
int enemigosDerrotados = 0;
bool tieneEspada = false;

Console.WriteLine(" ===== SIMULADOR GAMER ===== ");
Console.WriteLine(" 1. Mostrar el estado de el Jugador ");
Console.WriteLine(" 2. Encontrar una Espada Magica");
Console.WriteLine(" 3. Pelear contra un Enemigo");
Console.WriteLine(" 4. Comprar una Posición de Vida (20 monedas)");
Console.WriteLine(" 5. Salir del Juego");

Console.Write(" Elige una opción :");
string opcion = Console.ReadLine();

while (opcion != "5")
{
    switch (opcion)
    {
        case "1":
            Console.WriteLine(" \nNombre :" + nombre);
            Console.WriteLine(" Salud : " + salud);
            Console.WriteLine(" Monedas : " + monedas);
            Console.WriteLine(" Enemigos Derrotados : " + enemigosDerrotados);
            Console.WriteLine(" Espada :" + tieneEspada);

            Console.WriteLine(" Presione ENTER  para continuar.....");
            break;

        case "2":
            if (tieneEspada = true)
            {
                Console.WriteLine(" \n Ya tienes una espada");
            }
            else
            {
                Console.WriteLine(" \n..... ");
                Console.WriteLine(" ¡Encontraste una Espada Magica! Ahora puedes pelear mejor");
                tieneEspada = true;
            }
                Console.WriteLine(" Presione ENTER  para continuar.....");
            break;

        case "3":
            if (tieneEspada!)
            {
                Console.WriteLine("  \n¡¡PAW!! ");
                salud -= 10;
                enemigosDerrotados += 1;
                monedas += 10; 
                Console.WriteLine(" ¡Ganaste la batalla! Salud - 10 ");
            }
            else
            {
                Console.WriteLine(" \n¡El enemigo contraataca!");
                salud -= 30;
                enemigosDerrotados += 1;
                monedas += 5;
                Console.WriteLine(" ¡Fue una pelea dura sin espada!  Salud - 30");
            }
            Console.WriteLine(" Presione ENTER  para continuar.....");
            break;

        case "4":
            if (monedas >= 20)
            {
                monedas -= 20;
                salud += 20;

                Console.WriteLine(" \n¡Usaste una Posíón! +20 de salud");
            }
            else
            {
                Console.WriteLine(" \nNo tienes suficientes monedas");
            }
            Console.WriteLine(" Presione ENTER  para continuar.....");
            break;

        default:
            Console.WriteLine(" \n¡Opción invalida! Por favor ingrese su opción");
            Console.WriteLine(" Presione ENTER  para continuar.....");
            break;

    }
    Console.ReadKey();
    Console.Clear();

    Console.WriteLine(" \n ===== SIMULADOR GAMER ===== ");
    Console.WriteLine(" 1. Mostrar el estado de el Jugador ");
    Console.WriteLine(" 2. Encontrar una Espada Magica");
    Console.WriteLine(" 3. Pelear contra un Enemigo");
    Console.WriteLine(" 4. Comprar una Posición de Vida (20 monedas)");
    Console.WriteLine(" 5. Salir del Juego");

    Console.Write(" Elige una opción :");
    opcion = Console.ReadLine();

}
Console.WriteLine(" \n¡Gracias por usar el SIMULADOR GAMER!");

Console.ReadKey();