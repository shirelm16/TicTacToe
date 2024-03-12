using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum BoardState
    {
        InComplete, 
        Row0Win, 
        Row1Win, 
        Row2Win, 
        Col0Win, 
        Col1Win, 
        Col2Win, 
        Diag1Win, 
        Diag2Win, 
        Tie
    }

    public class BoardStatus
    {
        public BoardState State { get; set; }
        public char? WinningTile { get; set; }
    }

    public class Board
    {
        private Cell[,] _board;
        private int _emptyCells;

        public Board()
        {
            _board = new Cell[3, 3];
        }

        public void Init()
        {
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    _board[i, j] = new Cell();
                }
            }
            _emptyCells = _board.GetLength(0) * _board.GetLength(1);
        }

        public bool SetCell(int row, int col, char value)
        {
            if (IsValidCell(row, col) && _board[row, col].IsEmpty())
            {
                _board[row, col].SetValue(value);
                _emptyCells--;
                return true;
            }
            return false;
        }

        public bool ClearCell(int row, int col)
        {
            if (IsValidCell(row, col))
            {
                _board[row, col] = new Cell();
                _emptyCells++;
                return true;
            }
            return false;
        }

        public BoardStatus GetBoardStatus()
        {
            //check for row win
            if (!_board[0, 0].IsEmpty() && _board[0, 0].Value == _board[0, 1].Value &&
                _board[0, 1].Value == _board[0, 2].Value)
                return new BoardStatus{
                    State = BoardState.Row0Win,
                    WinningTile = _board[0, 0].Value
                };

            if (!_board[1, 0].IsEmpty() && _board[1, 0].Value == _board[1, 1].Value &&
                _board[1, 1].Value == _board[1, 2].Value)
                return new BoardStatus
                {
                    State = BoardState.Row1Win,
                    WinningTile = _board[1, 0].Value
                };

            if (!_board[2, 0].IsEmpty() && _board[2, 0].Value == _board[2, 1].Value &&
                _board[2, 1].Value == _board[2, 2].Value)
                return new BoardStatus
                {
                    State = BoardState.Row2Win,
                    WinningTile = _board[2, 0].Value
                };

            //check for column win
            if (!_board[0, 0].IsEmpty() && _board[0, 0].Value == _board[1, 0].Value &&
                _board[1, 0].Value == _board[2, 0].Value)
                return new BoardStatus
                {
                    State = BoardState.Col0Win,
                    WinningTile = _board[0, 0].Value
                };

            if (!_board[0, 1].IsEmpty() && _board[0, 1].Value == _board[1, 1].Value &&
                _board[1, 1].Value == _board[2, 1].Value)
                return new BoardStatus
                {
                    State = BoardState.Col1Win,
                    WinningTile = _board[0, 1].Value
                };

            if (!_board[0, 2].IsEmpty() && _board[0, 2].Value == _board[1, 2].Value &&
                _board[1, 2].Value == _board[2, 2].Value)
                return new BoardStatus
                {
                    State = BoardState.Col2Win,
                    WinningTile = _board[0, 2].Value
                };

            //check for diagonal win
            if (!_board[0, 0].IsEmpty() && _board[0, 0].Value == _board[1, 1].Value &&
                _board[1, 1].Value == _board[2, 2].Value)
                return new BoardStatus
                {
                    State = BoardState.Diag1Win,
                    WinningTile = _board[0, 0].Value
                };

            if (!_board[0, 2].IsEmpty() && _board[0, 2].Value == _board[1, 1].Value &&
                _board[1, 1].Value == _board[2, 0].Value)
                return new BoardStatus
                {
                    State = BoardState.Diag2Win,
                    WinningTile = _board[0, 2].Value
                };

            if (IsFull())
                return new BoardStatus
                {
                    State = BoardState.Tie
                };

            return new BoardStatus
            {
                State = BoardState.InComplete
            };
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
                    switch (_board[i, j].Value)
                    {
                        case ' ':
                            Console.Write("- ");
                            break;
                        case 'O':
                            Console.Write("O ");
                            break;
                        case 'X':
                            Console.Write("X ");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

        public List<(int row, int col)> GetEmptyCells()
        {
            var emptyCells = new List<(int row, int col)>();
            for(int i = 0; i < _board.GetLength(0); i++)
            {
                for(int j = 0; j < _board.GetLength(1); j++)
                {
                    if (_board[i, j].IsEmpty())
                    {
                        emptyCells.Add((i, j));
                    }
                }
            }
            return emptyCells;
        }

        private bool IsValidCell(int row, int col)
        {
            return row >= 0 && row < _board.GetLength(0)
                && col >= 0 && col < _board.GetLength(1);
        }
    }
}
