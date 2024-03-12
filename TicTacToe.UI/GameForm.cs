using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.UI
{
    public enum GameMode
    {
        TwoPlayers,
        OnePlayer
    };

    public partial class GameForm : Form
    {
        Game _game;
        GameMode _mode;

        public GameForm(GameMode mode)
        {
            InitializeComponent();
            _game = new Game();
            _mode = mode;
            RestartGame();
        }

        private Button GetButtonCell(int row, int col)
        {
            if (row == 0 && col == 0)
                return cellButton00;
            if(row == 0 && col == 1)
                return cellButton01;
            if(row == 0 && col == 2)
                return cellButton02;
            if (row == 1 && col == 0)
                return cellButton10;
            if(row == 1 && col == 1)
                return cellButton11;
            if(row == 1 && col == 2)
                return cellButton12;
            if (row == 2 && col == 0)
                return cellButton20;
            if(row == 2 && col == 1)
                return cellButton21;
            return cellButton22;
        }

        private void cellButton00_Click(object sender, EventArgs e)
        {
            PlayCell(0, 0, cellButton00);
        }

        private void cellButton01_Click(object sender, EventArgs e)
        {
            PlayCell(0, 1, cellButton01);
        }

        private void cellButton02_Click(object sender, EventArgs e)
        {
            PlayCell(0, 2, cellButton02);
        }

        private void cellButton10_Click(object sender, EventArgs e)
        {
            PlayCell(1, 0, cellButton10);
        }

        private void cellButton11_Click(object sender, EventArgs e)
        {
            PlayCell(1, 1, cellButton11);
        }

        private void cellButton12_Click(object sender, EventArgs e)
        {
            PlayCell(1, 2, cellButton12);
        }

        private void cellButton20_Click(object sender, EventArgs e)
        {
            PlayCell(2, 0, cellButton20);
        }

        private void cellButton21_Click(object sender, EventArgs e)
        {
            PlayCell(2, 1, cellButton21);
        }

        private void cellButton22_Click(object sender, EventArgs e)
        {
            PlayCell(2, 2, cellButton22);
        }

        private void PlayCell(int row, int col, Button cellButton)
        {
            if (_game.Play(row, col))
            {
                var gameState = _game.GetGameState();
                cellButton.Text = gameState.CurrentPlayer.PlayerTile.ToString();

                switch (gameState.BoardState)
                {
                    case BoardState.InComplete:
                        _game.ChangePlayer();
                        turnValueLabel.Text = gameState.CurrentPlayer.PlayerTile.ToString();
                        if(gameState.CurrentPlayer.PlayerTile == 'X' && _mode == GameMode.OnePlayer)
                        {
                            var move = _game.GetBestMove();
                            PlayCell(move.row, move.col, GetButtonCell(move.row, move.col));
                        }
                        break;
                    case BoardState.Row0Win:
                        Win(cellButton00, cellButton01, cellButton02, gameState.CurrentPlayer);
                        break;
                    case BoardState.Row1Win:
                        Win(cellButton10, cellButton11, cellButton12, gameState.CurrentPlayer);
                        break;
                    case BoardState.Row2Win:
                        Win(cellButton20, cellButton21, cellButton22, gameState.CurrentPlayer);
                        break;
                    case BoardState.Col0Win:
                        Win(cellButton00, cellButton10, cellButton20, gameState.CurrentPlayer);
                        break;
                    case BoardState.Col1Win:
                        Win(cellButton01, cellButton11, cellButton21, gameState.CurrentPlayer);
                        break;
                    case BoardState.Col2Win:
                        Win(cellButton02, cellButton12, cellButton22, gameState.CurrentPlayer);
                        break;
                    case BoardState.Diag1Win:
                        Win(cellButton00, cellButton11, cellButton22, gameState.CurrentPlayer);
                        break;
                    case BoardState.Diag2Win:
                        Win(cellButton02, cellButton11, cellButton20, gameState.CurrentPlayer);
                        break;
                    case BoardState.Tie:
                        Tie();
                        break;

                }
            }
        }

        private void Tie()
        {
            MessageBox.Show($"It's a tie!");
            RestartGame();
        }

        private void Win(Button btn1, Button btn2, Button btn3, Player player)
        {
            btn1.BackColor = Color.Green;
            btn2.BackColor = Color.Green;
            btn3.BackColor = Color.Green;

            MessageBox.Show($"Player {player.PlayerTile} wins!");

            if (player.PlayerTile == 'X')
            {
                playerXScoreLabel.Text = player.Score.ToString();
            }
            else
            {
                playerOScoreLabel.Text = player.Score.ToString();
            }

            RestartGame();
        }

        private void RestartGame()
        {
            _game.Init();
            RestartButtonCell(cellButton00);
            RestartButtonCell(cellButton01);
            RestartButtonCell(cellButton02);
            RestartButtonCell(cellButton10);
            RestartButtonCell(cellButton11);
            RestartButtonCell(cellButton12);
            RestartButtonCell(cellButton20);
            RestartButtonCell(cellButton21);
            RestartButtonCell(cellButton22);
            
            if (_mode == GameMode.OnePlayer)
            {
                var move = _game.GetBestMove();
                PlayCell(move.row, move.col, GetButtonCell(move.row, move.col));
            }
        }

        private void RestartButtonCell(Button btn)
        {
            btn.Text = string.Empty;
            btn.BackColor = SystemColors.Control;
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
