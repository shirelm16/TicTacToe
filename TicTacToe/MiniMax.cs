using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Move
    {
        public int? Row { get; set; }
        public int? Column { get; set; }
        public int Score { get; set; }
    }
    public static class MiniMax
    {
        public static Move BestMove(Board board, int depth, bool maximize)
        {
            var boardStatus = board.GetBoardStatus();
            if (IsTerminalState(boardStatus.State))
            {
                return new Move
                {
                    Score = GetScore(boardStatus, depth)
                };
            }

            depth++;
            if(maximize)
            {
                int maxScore = int.MinValue;
                int? row = null, column = null;
                foreach (var cell in board.GetEmptyCells())
                {
                    board.SetCell(cell.row, cell.col, 'X');
                    var moveScore = BestMove(board, depth, false).Score;
                    if(moveScore > maxScore)
                    {
                        maxScore = moveScore;
                        row = cell.row; 
                        column = cell.col;
                    }
                    board.ClearCell(cell.row, cell.col);
                }
                return new Move
                {
                    Row = row,
                    Column = column,
                    Score = maxScore
                };
            }
            else //Minimize
            {
                int minScore = int.MaxValue;
                int? row = null, column = null;
                foreach (var cell in board.GetEmptyCells())
                {
                    board.SetCell(cell.row, cell.col, 'O');
                    var moveScore = BestMove(board, depth, true).Score;
                    if (moveScore < minScore)
                    {
                        row = cell.row;
                        column = cell.col;
                        minScore = moveScore;
                    }
                    board.ClearCell(cell.row, cell.col);
                }
                return new Move
                {
                    Row = row,
                    Column = column,
                    Score = minScore
                };
            }
        }

        private static int GetScore(BoardStatus boardStatus, int depth)
        {
            if (boardStatus.State == BoardState.Tie)
            {
                return 0;
            }
            else if (boardStatus.WinningTile == 'X')
            {
                return 10 - depth;
            }
            else return -10 + depth;
        }

        private static bool IsTerminalState(BoardState boardState)
        {
            return boardState != BoardState.InComplete;
        }
    }
}
