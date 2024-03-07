namespace TicTacToe.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void twoPlayersButton_Click(object sender, EventArgs e)
        {
            Hide();
            var gameForm = new GameForm();
            gameForm.Show();
        }
    }
}
