using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.Start();
            Console.WriteLine("Start again? Y/N");
            var startAgain = Console.ReadLine();

            while (startAgain.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                game.Start();
                Console.WriteLine("Start again? Y/N");
                startAgain = Console.ReadLine();
            }            
        }
    }
}
