using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        // Exit.
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
            mainGameUI.Show();
            this.Hide();
        }

        //TODO Load game.

        private void InitialMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit.
            Pet.SaveGame();
            Application.Exit();
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            //Load game from saveGame.txt.
            bool saveFileExists = Pet.LoadGame();
            if (!saveFileExists)
            {
                MessageBox.Show("No save file found! Starting new game...");
            }
            //Show main game window.
            MainGameUI mainGameUI = new MainGameUI();
            mainGameUI.Left = this.Left;
            mainGameUI.Top = this.Top;
            mainGameUI.Size = this.Size;
            mainGameUI.Show();
            this.Hide();
        }
    }
}
