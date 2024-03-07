namespace TicTacToe.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TicTacToeLabel = new Label();
            twoPlayersButton = new Button();
            onePlayerButton = new Button();
            exitButton = new Button();
            CreatedByLabel = new Label();
            SuspendLayout();
            // 
            // TicTacToeLabel
            // 
            TicTacToeLabel.AutoSize = true;
            TicTacToeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TicTacToeLabel.Location = new Point(173, 73);
            TicTacToeLabel.Name = "TicTacToeLabel";
            TicTacToeLabel.Size = new Size(122, 31);
            TicTacToeLabel.TabIndex = 0;
            TicTacToeLabel.Text = "Tic Tac Toe";
            // 
            // twoPlayersButton
            // 
            twoPlayersButton.Location = new Point(173, 165);
            twoPlayersButton.Name = "twoPlayersButton";
            twoPlayersButton.Size = new Size(122, 29);
            twoPlayersButton.TabIndex = 2;
            twoPlayersButton.Text = "2 Players";
            twoPlayersButton.UseVisualStyleBackColor = true;
            twoPlayersButton.Click += twoPlayersButton_Click;
            // 
            // onePlayerButton
            // 
            onePlayerButton.Enabled = false;
            onePlayerButton.Location = new Point(173, 130);
            onePlayerButton.Name = "onePlayerButton";
            onePlayerButton.Size = new Size(122, 29);
            onePlayerButton.TabIndex = 1;
            onePlayerButton.Text = "1 Player";
            onePlayerButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(173, 246);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(122, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // CreatedByLabel
            // 
            CreatedByLabel.AutoSize = true;
            CreatedByLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatedByLabel.Location = new Point(12, 427);
            CreatedByLabel.Name = "CreatedByLabel";
            CreatedByLabel.Size = new Size(170, 17);
            CreatedByLabel.TabIndex = 4;
            CreatedByLabel.Text = "Created by Shirel Menahem";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(CreatedByLabel);
            Controls.Add(exitButton);
            Controls.Add(onePlayerButton);
            Controls.Add(twoPlayersButton);
            Controls.Add(TicTacToeLabel);
            Name = "MainForm";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TicTacToeLabel;
        private Button twoPlayersButton;
        private Button onePlayerButton;
        private Button exitButton;
        private Label CreatedByLabel;
    }
}
