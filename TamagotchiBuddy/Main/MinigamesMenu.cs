using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Gabi: Fun filling up by 1 on every game
            if (Pet.Fun < 6)
            {
                Pet.Fun += 1;
            }
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
