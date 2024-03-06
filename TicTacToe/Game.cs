using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        private Board _board;
        private Player _player1;
        private Player _player2;

        public Game()
        {
            _board = new Board();

            Console.WriteLine("Enter first player name: ");
            string player1Name = Console.ReadLine();
            _player1 = new Player(player1Name, GameTile.O);

            Console.WriteLine("Enter second player name: ");
            string player2Name = Console.ReadLine();
            _player2 = new Player(player2Name, GameTile.X);
        }

        public void Start()
        {
            _board.Init();
            _board.PrintBoard();
            do
            {
                Console.WriteLine($"It's {_player1.Name}'s turn. Please enter a row numer:");
                var row1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a column numer:");
                var col1 = int.Parse(Console.ReadLine());

                ValidatePlayerTurn(row1, col1, _player1.PlayerTile);
                _board.PrintBoard();

                if (IsWin() || IsTie())
                    break;

                Console.WriteLine($"It's {_player2.Name}'s turn. Please enter a row numer:");
                var row2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a column numer:");
                var col2 = int.Parse(Console.ReadLine());

                ValidatePlayerTurn(row2, col2, _player2.PlayerTile);
                _board.PrintBoard();

            }
            while (!IsWin() && !IsTie());
        }

        private bool IsTie()
        {
            if (_board.IsFull())
            {
                Console.WriteLine("It's a tie!");
                _player1.Tie();
                _player2.Tie();
                return true;
            }
            return false;

        }

        private void ValidatePlayerTurn(int row, int col, GameTile playerTile)
        {
            while (!_board.SetCell(row, col, playerTile))
            {
                Console.WriteLine("Invalid input! Row and column must be between 0 and 2 and cell must be empty!");
                Console.WriteLine("Please enter a row numer:");
                row = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a column numer:");
                col = int.Parse(Console.ReadLine());
            }
        }

        private bool IsWin()
        {
            if (_board.IsWin(_player1.PlayerTile))
            {
                Console.WriteLine($"{_player1.Name} wins!");
                _player1.Win();
                _player2.Lose();
                return true;
            }

            if (_board.IsWin(_player2.PlayerTile))
            {
                Console.WriteLine($"{_player2.Name} wins!");
                _player2.Win();
                _player1.Lose();
                return true;
            }

            return false;
        }
    }
}
