using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPiedraPapelTijera
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Primer Numero");
            //numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("PIEDRA || PAPEL || TIJERA");

            bool menu = true;

            int modoJuego = 0;

            int opcionPc = 0;

            int opcionJugador1 = 0;

            int opcionJugador2 = 0;

            bool correcto = true;

            while (menu)
            {

                Console.WriteLine("1 - UN JUGADOR");
                Console.WriteLine("2 - DOS JUGADORES");

                Console.Write("SELECCIONE MODO DE JUEGO(1 o 2): ");
                modoJuego = Int32.Parse(Console.ReadLine());

                if (modoJuego == 1)
                {
                    Console.WriteLine("UN JUGADOR");
                    Random random = new Random();

                    opcionPc = random.Next(1,4);

                    while (correcto) { 

                        Console.WriteLine("ELIJA UNA OPCION");
                        Console.WriteLine("1 - Tijera");
                        Console.WriteLine("2 - Piedra");
                        Console.WriteLine("3 - Papel");

                        opcionJugador1 = Int32.Parse(Console.ReadLine());

                        if (opcionJugador1 >= 1 && opcionJugador1 <= 3) {
                            correcto = false;
                        }
                    }

                    if (opcionJugador1 == 1 && opcionPc == 2)
                    {
                        Console.WriteLine($"Usted eligio: {opcionJugador1}");
                        Console.WriteLine($"El BOT eligio: {opcionPc}");

                        Console.WriteLine("GANO EL BOT");
                    }
                    else if (opcionJugador1 == 1 && opcionPc == 3)
                    {
                        Console.WriteLine($"Usted eligio: {opcionJugador1}");
                        Console.WriteLine($"El BOT eligio: {opcionPc}");

                        Console.WriteLine("GANO EL JUGADOR");
                    }
                    else if (opcionJugador1 == 2 && opcionPc == 1)
                    {
                        Console.WriteLine($"Usted eligio: {opcionJugador1}");
                        Console.WriteLine($"El BOT eligio: {opcionPc}");

                        Console.WriteLine("GANO EL JUGADOR");
                    }
                    else if (opcionJugador1 == 2 && opcionPc == 3)
                    {
                        Console.WriteLine($"Usted eligio: {opcionJugador1}");
                        Console.WriteLine($"El BOT eligio: {opcionPc}");

                        Console.WriteLine("GANO EL BOT");
                    }
                    else if (opcionJugador1 == 3 && opcionPc == 1)
                    {
                        Console.WriteLine($"Usted eligio: {opcionJugador1}");
                        Console.WriteLine($"El BOT eligio: {opcionPc}");

                        Console.WriteLine("GANO EL BOT");
                    }
                    else if (opcionJugador1 == 3 && opcionPc == 2)
                    {
                        Console.WriteLine($"Usted eligio: {opcionJugador1}");
                        Console.WriteLine($"El BOT eligio: {opcionPc}");

                        Console.WriteLine("GANO EL JUGADOR");
                    }
                    else {
                        Console.WriteLine($"Usted eligio: {opcionJugador1}");
                        Console.WriteLine($"El BOT eligio: {opcionPc}");

                        Console.WriteLine("EMPATE");
                    }

                    menu = false;

                }

                else if (modoJuego == 2)
                {
                    Console.WriteLine("DOS JUGADORES");

                    while (correcto)
                    {

                        Console.WriteLine("JUGADOR 1 ELIJA UNA OPCION");
                        Console.WriteLine("1 - Tijera");
                        Console.WriteLine("2 - Piedra");
                        Console.WriteLine("3 - Papel");

                        opcionJugador1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("JUGADOR 2 ELIJA UNA OPCION");
                        Console.WriteLine("1 - Tijera");
                        Console.WriteLine("2 - Piedra");
                        Console.WriteLine("3 - Papel");

                        opcionJugador2 = Int32.Parse(Console.ReadLine());

                        if ((opcionJugador1 >= 1 && opcionJugador1 <= 3) || (opcionJugador2 >= 1 && opcionJugador2 <= 3))
                        {
                            correcto = false;
                        }
                    }

                    if (opcionJugador1 == 1 && opcionJugador2 == 2)
                    {
                        Console.WriteLine($"Jugador 1 eligio: {opcionJugador1}");
                        Console.WriteLine($"Jugador 2 eligio: {opcionJugador2}");

                        Console.WriteLine("GANO EL Jugador 2");
                    }
                    else if (opcionJugador1 == 1 && opcionJugador2 == 3)
                    {
                        Console.WriteLine($"Jugador 1 eligio: {opcionJugador1}");
                        Console.WriteLine($"Jugador 2 eligio: {opcionJugador2}");

                        Console.WriteLine("GANO EL Jugador 1");
                    }
                    else if (opcionJugador1 == 2 && opcionJugador2 == 1)
                    {
                        Console.WriteLine($"Jugador 1 eligio: {opcionJugador1}");
                        Console.WriteLine($"Jugador 2 eligio: {opcionJugador2}");

                        Console.WriteLine("GANO EL Jugador 1");
                    }
                    else if (opcionJugador1 == 2 && opcionJugador2 == 3)
                    {
                        Console.WriteLine($"Jugador 1 eligio: {opcionJugador1}");
                        Console.WriteLine($"Jugador 2 eligio: {opcionJugador2}");

                        Console.WriteLine("GANO EL Jugador 2");
                    }
                    else if (opcionJugador1 == 3 && opcionJugador2 == 1)
                    {
                        Console.WriteLine($"Jugador 1 eligio: {opcionJugador1}");
                        Console.WriteLine($"Jugador 2 eligio: {opcionJugador2}");

                        Console.WriteLine("GANO EL Jugador 2");
                    }
                    else if (opcionJugador1 == 3 && opcionJugador2 == 2)
                    {
                        Console.WriteLine($"Jugador 1 eligio: {opcionJugador1}");
                        Console.WriteLine($"Jugador 2 eligio: {opcionJugador2}");

                        Console.WriteLine("GANO EL Jugador 1");
                    }
                    else
                    {
                        Console.WriteLine($"Jugador 1 eligio: {opcionJugador1}");
                        Console.WriteLine($"Jugador 2 eligio: {opcionJugador2}");

                        Console.WriteLine("EMPATE");
                    }

                    menu = false;

                }

                else 
                {
                    Console.WriteLine("Ingreso una opcion incorrecta");
                }
            }
        }
    }
}
