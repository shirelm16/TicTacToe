using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameState
    {
        public BoardState BoardState { get; set; }
        public Player CurrentPlayer { get; set; }
    }

    public class Game
    {
        private Board _board;
        private Player _playerX;
        private Player _playerO;
        private GameState _state;

        public Game()
        {
            _board = new Board();
            _playerX = new Player('X');
            _playerO = new Player('O');
        }

        public void Init()
        {
            _board.Init();
            _state = new GameState
            {
                BoardState = BoardState.None,
                CurrentPlayer = _playerX,
            };
        }

        public bool Play(int row, int col)
        {
            if (_board.SetCell(row, col, _state.CurrentPlayer.PlayerTile))
            {
                _state.BoardState = _board.GetBoardState();

                if (IsWin())
                {
                    _state.CurrentPlayer.UpdateScore();                
                }
                return true;
            }
            return false;
        }

        public void ChangePlayer()
        {
            _state.CurrentPlayer = _state.CurrentPlayer == _playerX ? _playerO : _playerX;
        }

        public GameState GetGameState()
        {
            return _state;
        }

        public bool IsWin()
        {
            return _state.BoardState == BoardState.Row0Win ||
            _state.BoardState == BoardState.Row1Win ||
            _state.BoardState == BoardState.Row2Win ||
            _state.BoardState == BoardState.Col0Win ||
            _state.BoardState == BoardState.Col1Win ||
            _state.BoardState == BoardState.Col2Win ||
            _state.BoardState == BoardState.Diag1Win ||
            _state.BoardState == BoardState.Diag2Win;
        }

        public bool IsTie()
        {
            return _state.BoardState == BoardState.Tie;
        }
    }
}
