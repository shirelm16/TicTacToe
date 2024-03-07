﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum BoardState
    {
        None, 
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
            if (IsValidCell(row, col))
            {
                _board[row, col].SetValue(value);
                _emptyCells--;
                return true;
            }
            return false;
        }

        public BoardState GetBoardState()
        {
            //check for row win
            if (!_board[0, 0].IsEmpty() && _board[0, 0].Value == _board[0, 1].Value &&
                _board[0, 1].Value == _board[0, 2].Value)
                return BoardState.Row0Win;

            if (!_board[1, 0].IsEmpty() && _board[1, 0].Value == _board[1, 1].Value &&
                _board[1, 1].Value == _board[1, 2].Value)
                return BoardState.Row1Win;

            if (!_board[2, 0].IsEmpty() && _board[2, 0].Value == _board[2, 1].Value &&
                _board[2, 1].Value == _board[2, 2].Value)
                return BoardState.Row2Win;

            //check for column win
            if (!_board[0, 0].IsEmpty() && _board[0, 0].Value == _board[1, 0].Value &&
                _board[1, 0].Value == _board[2, 0].Value)
                return BoardState.Col0Win;

            if (!_board[0, 1].IsEmpty() && _board[0, 1].Value == _board[1, 1].Value &&
                _board[1, 1].Value == _board[2, 1].Value)
                return BoardState.Col1Win;

            if (!_board[0, 2].IsEmpty() && _board[0, 2].Value == _board[1, 2].Value &&
                _board[1, 2].Value == _board[2, 2].Value)
                return BoardState.Col2Win;

            //check for diagonal win
            if (!_board[0, 0].IsEmpty() && _board[0, 0].Value == _board[1, 1].Value &&
                _board[1, 1].Value == _board[2, 2].Value)
                return BoardState.Diag1Win;

            if (!_board[0, 2].IsEmpty() && _board[0, 2].Value == _board[1, 1].Value &&
                _board[1, 1].Value == _board[2, 0].Value)
                return BoardState.Diag2Win;

            if (IsFull())
                return BoardState.Tie;

            return BoardState.None;
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

        private bool IsValidCell(int row, int col)
        {
            return row >= 0 && row < _board.GetLength(0)
                && col >= 0 && col < _board.GetLength(1)
                && _board[row, col].IsEmpty();
        }
    }
}
