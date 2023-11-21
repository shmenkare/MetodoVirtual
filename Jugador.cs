using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodoVirtual
{
    class Jugador
    {
        public void RealizarMovida()
        {
            Console.WriteLine("Clase: Jugador, Metodo: RealizarMovida");
        }
    }
    class Juego
    {
        Jugador jugador1;
        Jugador jugador2;

        public void EmpezarPartida(Jugador jug1, Jugador jug2)
        {
            jugador1 = jug1;
            jugador2 = jug2;
            jugador1.RealizarMovida();
            jugador2.RealizarMovida();
        }
    }

    class Bot1 : Jugador
    {
        public void RealizarMovida()
        {
            Console.WriteLine("Clase: Bot1, Metodo: RealizarMovida");
        }
    }
    class Bot2 : Jugador
    {
        public void RealizarMovida()
        {
            Console.WriteLine("Clase: Bot2, Metodo: RealizarMovida");
        }
    }
}
