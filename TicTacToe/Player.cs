using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public int GamesWon { get; private set; }
        public int GamesLost { get; private set; }
        public int GamesPlayed { get; private set; }

        public string Name { get; private set; }

        public GameTile PlayerTile { get; private set; }

        public Player(string name, GameTile tile)
        {
            Name = name;
            PlayerTile = tile;
        }

        public void Win()
        {
            GamesPlayed++;
            GamesWon++;
        }

        public void Lose()
        {
            GamesPlayed++;
            GamesLost++;
        }

        public void Tie()
        {
            GamesPlayed++;
        }
    }
}
