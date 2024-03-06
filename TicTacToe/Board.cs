using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum GameTile
    {
        X, O, Empty
    }

    public class Board
    {
        private GameTile[,] _board;
        private int _emptyCells;

        public Board()
        {
            _board = new GameTile[3, 3];
        }

        public void Init()
        {
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    _board[i, j] = GameTile.Empty;
                }
            }
            _emptyCells = 9;
        }

        public bool SetCell(int row, int col, GameTile value)
        {
            if (!IsValidCell(row, col))
                return false;

            _board[row, col] = value;
            _emptyCells--;
            return true;
        }

        public bool IsWin(GameTile tile)
        {
            return IsRowWin(tile) || IsColumnWin(tile) || IsDiagonalWin(tile);
        }

        public bool IsFull()
        {
            return _emptyCells == 0;
        }

        public void PrintBoard()
        {
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    switch (_board[i, j])
                    {
                        case GameTile.Empty:
                            Console.Write("- ");
                            break;
                        case GameTile.O:
                            Console.Write("O ");
                            break;
                        case GameTile.X:
                            Console.Write("X ");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

        private bool IsRowWin(GameTile tile)
        {
            for(int i=0; i<_board.GetLength(0);i++)
            {
                if (_board[i, 0] == tile && _board[i, 1] == tile && _board[i, 2] == tile)
                    return true;
            }
            return false;
        }

        private bool IsColumnWin(GameTile tile)
        {
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                if (_board[0, j] == tile && _board[1, j] == tile && _board[2, j] == tile)
                    return true;
            }
            return false;
        }

        private bool IsDiagonalWin(GameTile tile)
        {
            return (_board[0, 0] == tile && _board[1, 1] == tile && _board[2, 2] == tile) ||
                (_board[0, 2] == tile && _board[1, 1] == tile && _board[2, 0] == tile);
        }

        private bool IsValidCell(int row, int col)
        {
            return row >= 0 && row < _board.GetLength(0)
                && col >= 0 && col < _board.GetLength(1)
                && _board[row, col] == GameTile.Empty;
        }
    }
}
