using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodoVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jugador jug1 = new Jugador();
            //Jugador jug2 = new Jugador();
            //Juego j = new Juego();
            //j.EmpezarPartida(jug1, jug2);

            Bot1 jug1 = new Bot1();
            Bot2 jug2 = new Bot2();
            Juego j = new Juego();
            j.EmpezarPartida(jug1, jug2);
            jug1.RealizarMovida();

            Console.ReadKey();

        }
    }
}
