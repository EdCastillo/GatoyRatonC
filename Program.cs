using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoyRaton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity gato = new Entity { Name="Gato", Position = 0 };
            Entity raton = new Entity { Name = "Raton", Position = 30 };


            for (int i = 0; i < 10; i++) {
                raton.RealizarMovimiento();
                if (PartidaTerminada(gato, raton)) break;
                gato.RealizarMovimiento();
                if (PartidaTerminada(gato, raton)) break;
            }

            Console.ReadLine();


        }

        public static bool PartidaTerminada(Entity g, Entity r) {
            if (g.Position == r.Position) {
                Console.WriteLine("El gato ha ganado!");
                return true;
            }
            if (r.Position == 0) { 
                Console.WriteLine("El raton ha ganado!");
                return true;
            }
            if (r.UsedMoves.Count() == 9 && g.UsedMoves.Count() == 9) {
                Console.WriteLine("El juego ha quedado en un empate!");
                return true;
            }
            return false;

        }


        
    }
}
