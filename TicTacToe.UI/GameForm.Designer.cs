namespace TicTacToe.UI
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ticTacToeLabel = new Label();
            boardGroupBox = new GroupBox();
            cellButton22 = new Button();
            cellButton12 = new Button();
            cellButton02 = new Button();
            cellButton21 = new Button();
            cellButton11 = new Button();
            cellButton01 = new Button();
            cellButton20 = new Button();
            cellButton10 = new Button();
            cellButton00 = new Button();
            turnLabel = new Label();
            turnValueLabel = new Label();
            playerXLabel = new Label();
            playerOLabel = new Label();
            playerXScoreLabel = new Label();
            playerOScoreLabel = new Label();
            boardGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ticTacToeLabel
            // 
            ticTacToeLabel.AutoSize = true;
            ticTacToeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticTacToeLabel.Location = new Point(173, 73);
            ticTacToeLabel.Name = "ticTacToeLabel";
            ticTacToeLabel.Size = new Size(122, 31);
            ticTacToeLabel.TabIndex = 1;
            ticTacToeLabel.Text = "Tic Tac Toe";
            // 
            // boardGroupBox
            // 
            boardGroupBox.Controls.Add(cellButton22);
            boardGroupBox.Controls.Add(cellButton12);
            boardGroupBox.Controls.Add(cellButton02);
            boardGroupBox.Controls.Add(cellButton21);
            boardGroupBox.Controls.Add(cellButton11);
            boardGroupBox.Controls.Add(cellButton01);
            boardGroupBox.Controls.Add(cellButton20);
            boardGroupBox.Controls.Add(cellButton10);
            boardGroupBox.Controls.Add(cellButton00);
            boardGroupBox.Location = new Point(70, 129);
            boardGroupBox.Name = "boardGroupBox";
            boardGroupBox.Size = new Size(207, 219);
            boardGroupBox.TabIndex = 2;
            boardGroupBox.TabStop = false;
            // 
            // cellButton22
            // 
            cellButton22.Font = new Font("Segoe UI", 16.2F);
            cellButton22.Location = new Point(136, 147);
            cellButton22.Name = "cellButton22";
            cellButton22.Size = new Size(70, 70);
            cellButton22.TabIndex = 8;
            cellButton22.UseVisualStyleBackColor = true;
            cellButton22.Click += cellButton22_Click;
            // 
            // cellButton12
            // 
            cellButton12.Font = new Font("Segoe UI", 16.2F);
            cellButton12.Location = new Point(136, 79);
            cellButton12.Name = "cellButton12";
            cellButton12.Size = new Size(70, 70);
            cellButton12.TabIndex = 5;
            cellButton12.UseVisualStyleBackColor = true;
            cellButton12.Click += cellButton12_Click;
            // 
            // cellButton02
            // 
            cellButton02.Font = new Font("Segoe UI", 16.2F);
            cellButton02.Location = new Point(136, 11);
            cellButton02.Name = "cellButton02";
            cellButton02.Size = new Size(70, 70);
            cellButton02.TabIndex = 2;
            cellButton02.UseVisualStyleBackColor = true;
            cellButton02.Click += cellButton02_Click;
            // 
            // cellButton21
            // 
            cellButton21.Font = new Font("Segoe UI", 16.2F);
            cellButton21.Location = new Point(68, 147);
            cellButton21.Name = "cellButton21";
            cellButton21.Size = new Size(70, 70);
            cellButton21.TabIndex = 7;
            cellButton21.UseVisualStyleBackColor = true;
            cellButton21.Click += cellButton21_Click;
            // 
            // cellButton11
            // 
            cellButton11.Font = new Font("Segoe UI", 16.2F);
            cellButton11.Location = new Point(68, 79);
            cellButton11.Name = "cellButton11";
            cellButton11.Size = new Size(70, 70);
            cellButton11.TabIndex = 4;
            cellButton11.UseVisualStyleBackColor = true;
            cellButton11.Click += cellButton11_Click;
            // 
            // cellButton01
            // 
            cellButton01.Font = new Font("Segoe UI", 16.2F);
            cellButton01.Location = new Point(68, 11);
            cellButton01.Name = "cellButton01";
            cellButton01.Size = new Size(70, 70);
            cellButton01.TabIndex = 1;
            cellButton01.UseVisualStyleBackColor = true;
            cellButton01.Click += cellButton01_Click;
            // 
            // cellButton20
            // 
            cellButton20.Font = new Font("Segoe UI", 16.2F);
            cellButton20.Location = new Point(0, 147);
            cellButton20.Name = "cellButton20";
            cellButton20.Size = new Size(70, 70);
            cellButton20.TabIndex = 6;
            cellButton20.UseVisualStyleBackColor = true;
            cellButton20.Click += cellButton20_Click;
            // 
            // cellButton10
            // 
            cellButton10.Font = new Font("Segoe UI", 16.2F);
            cellButton10.Location = new Point(0, 79);
            cellButton10.Name = "cellButton10";
            cellButton10.Size = new Size(70, 70);
            cellButton10.TabIndex = 3;
            cellButton10.UseVisualStyleBackColor = true;
            cellButton10.Click += cellButton10_Click;
            // 
            // cellButton00
            // 
            cellButton00.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellButton00.Location = new Point(0, 11);
            cellButton00.Name = "cellButton00";
            cellButton00.Size = new Size(70, 70);
            cellButton00.TabIndex = 0;
            cellButton00.UseVisualStyleBackColor = true;
            cellButton00.Click += cellButton00_Click;
            // 
            // turnLabel
            // 
            turnLabel.BackColor = Color.SkyBlue;
            turnLabel.BorderStyle = BorderStyle.FixedSingle;
            turnLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            turnLabel.ForeColor = Color.Black;
            turnLabel.Location = new Point(283, 140);
            turnLabel.Name = "turnLabel";
            turnLabel.Size = new Size(135, 25);
            turnLabel.TabIndex = 3;
            turnLabel.Text = "Turn:";
            turnLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // turnValueLabel
            // 
            turnValueLabel.BorderStyle = BorderStyle.FixedSingle;
            turnValueLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turnValueLabel.Location = new Point(283, 165);
            turnValueLabel.Name = "turnValueLabel";
            turnValueLabel.Size = new Size(135, 31);
            turnValueLabel.TabIndex = 4;
            turnValueLabel.Text = "X";
            turnValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerXLabel
            // 
            playerXLabel.AutoSize = true;
            playerXLabel.BackColor = Color.MediumSeaGreen;
            playerXLabel.BorderStyle = BorderStyle.FixedSingle;
            playerXLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerXLabel.ForeColor = Color.White;
            playerXLabel.Location = new Point(283, 221);
            playerXLabel.Name = "playerXLabel";
            playerXLabel.Size = new Size(68, 25);
            playerXLabel.TabIndex = 5;
            playerXLabel.Text = "PlayerX";
            playerXLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerOLabel
            // 
            playerOLabel.AutoSize = true;
            playerOLabel.BackColor = Color.MediumSeaGreen;
            playerOLabel.BorderStyle = BorderStyle.FixedSingle;
            playerOLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerOLabel.ForeColor = Color.White;
            playerOLabel.Location = new Point(350, 221);
            playerOLabel.Name = "playerOLabel";
            playerOLabel.Size = new Size(71, 25);
            playerOLabel.TabIndex = 6;
            playerOLabel.Text = "PlayerO";
            playerOLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerXScoreLabel
            // 
            playerXScoreLabel.BorderStyle = BorderStyle.FixedSingle;
            playerXScoreLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerXScoreLabel.Location = new Point(283, 246);
            playerXScoreLabel.Name = "playerXScoreLabel";
            playerXScoreLabel.Size = new Size(67, 31);
            playerXScoreLabel.TabIndex = 7;
            playerXScoreLabel.Text = "0";
            playerXScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerOScoreLabel
            // 
            playerOScoreLabel.BorderStyle = BorderStyle.FixedSingle;
            playerOScoreLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerOScoreLabel.Location = new Point(350, 246);
            playerOScoreLabel.Name = "playerOScoreLabel";
            playerOScoreLabel.Size = new Size(71, 31);
            playerOScoreLabel.TabIndex = 8;
            playerOScoreLabel.Text = "0";
            playerOScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(playerOScoreLabel);
            Controls.Add(playerXScoreLabel);
            Controls.Add(playerOLabel);
            Controls.Add(playerXLabel);
            Controls.Add(turnValueLabel);
            Controls.Add(turnLabel);
            Controls.Add(boardGroupBox);
            Controls.Add(ticTacToeLabel);
            Name = "GameForm";
            Text = "Tic Tac Toe";
            FormClosing += GameForm_FormClosing;
            boardGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ticTacToeLabel;
        private GroupBox boardGroupBox;
        private Button cellButton00;
        private Button cellButton22;
        private Button cellButton12;
        private Button cellButton02;
        private Button cellButton21;
        private Button cellButton11;
        private Button cellButton01;
        private Button cellButton20;
        private Button cellButton10;
        private Label turnLabel;
        private Label turnValueLabel;
        private Label playerXLabel;
        private Label playerOLabel;
        private Label playerXScoreLabel;
        private Label playerOScoreLabel;
    }
}