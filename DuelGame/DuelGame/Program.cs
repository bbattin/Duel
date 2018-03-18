using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Magician a = new Magician("Bob");
            Beast b = new Beast("Rex");

            GameLogic.Duel(a, b);

            Console.ReadKey();
        }
    }
}
