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
    public partial class InitialMenu : Form
    {
        public InitialMenu()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you really want to exit the game?", "Exit?", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            MainGameUI mainGameUI = new MainGameUI();
            mainGameUI.Left = this.Left;
            mainGameUI.Top = this.Top;
            mainGameUI.Size = this.Size;
            this.Hide();
            mainGameUI.Show();
        }

        private void InitialMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit.
            Application.Exit();
        }
    }
}
