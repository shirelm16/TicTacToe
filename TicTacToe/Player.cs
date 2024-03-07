using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public int Score { get; private set; } = 0;
        public char PlayerTile { get; private set; }

        public Player(char tile)
        {
            PlayerTile = tile;
        }

        public void UpdateScore()
        {
            Score++;
        }
    }
}
