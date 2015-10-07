using System;
using System.Windows.Forms;

namespace Main
{
    public partial class MinigamesMenu : Form
    {
        public MinigamesMenu()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minigameButton1_Click(object sender, EventArgs e)
        {
            TicTacToe tictactoe = new TicTacToe();
            tictactoe.StartPosition = FormStartPosition.CenterParent;
            tictactoe.ShowDialog();
        }

        private void minigameButton5_Click(object sender, EventArgs e)
        {
            Ballgame ballgame = new Ballgame();
            ballgame.StartPosition = FormStartPosition.CenterParent;
            ballgame.ShowDialog();
        }

        private void minigameButton4_Click(object sender, EventArgs e)
        {
            MatchTwoGame matchTwoGame = new MatchTwoGame();
            matchTwoGame.StartPosition = FormStartPosition.CenterParent;
            matchTwoGame.ShowDialog();   
        }

        private void MinigamesMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "27")
            {
                this.Close();
            }
        }
    }
}
