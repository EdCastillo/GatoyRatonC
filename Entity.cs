using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoyRaton
{
    internal class Entity
    {
        public string Name { get; set; }
        public int Position {get; set; }

        public List<int> UsedMoves = new List<int>();

        private void MoveX(int param,string n) {

            
            if (param > 9 || param < 1) {
                Console.WriteLine("Movimiento no valido");
                return;
            }
            if (UsedMoves.Count() == 0)
            {
                if (!n.Equals("-") && Name.Equals("Raton")) {
                    n = "-";
                }
                UsedMoves.Add(param);
            }
            else
            {
                foreach (var move in UsedMoves)
                {
                    if (move == param)
                    {
                        Console.WriteLine("Este movimiento ya fue realizado");
                        return;
                    }
                }
                UsedMoves.Add(param);
            }
            if (n == "-")
            {
                Position -= param;
            }
            else
            {
                if (Name.Equals("Raton") && (Position + param) > 30)
                {
                    Position -= param;
                }
                else
                {
                    Position += param;
                }
            }
           
        
        }

        public void RealizarMovimiento() {
            Console.WriteLine("Movimiento del " + Name);
            Console.WriteLine("Movimientos disponibles: ");
            for (int i = 1; i < 10; i++) {
                bool flag = true;
                foreach (var move in UsedMoves) {
                    if (i == move) {
                        flag = false; 
                        break;
                    }

                }
                if (flag) {
                    Console.Write(i+" ");
                }
                
            }
            Console.WriteLine("");
                string param=Console.ReadLine();
                if (param.Contains("-")) {
                    MoveX(Int32.Parse(param)*-1, "-");
                    
                }
            else { MoveX(Int32.Parse(param), "+"); }
                
            Console.WriteLine("El raton esta en la posicion " + Position);
            Console.WriteLine("********************************************");
                return;
            
        
        }
    }
}
