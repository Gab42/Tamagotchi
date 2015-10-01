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
    public partial class MainGameUI : Form
    {
        Pet pet = new Pet();
        public MainGameUI()
        {
            InitializeComponent();          
            hungerBar.Value = pet.Hunger;
            tirednessBar.Value = pet.Tiredness;
            hygeneBar.Value = pet.Hygene;
            funBar.Value = pet.Fun;
        }

        private void MainGameUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO save before exiting.
            // Exit.
            Application.Exit();
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            if (pet.Hunger < hungerBar.Maximum)
            {
                pet.Hunger += 1;
                hungerBar.Value = pet.Hunger;
            }
        }

        private void sleepButton_Click(object sender, EventArgs e)
        {
            //TODO - lights off animation, pet tiredness bar should start going up slowly.
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            if (pet.Hygene < hygeneBar.Maximum)
            {
                pet.Hygene += 1;
                hygeneBar.Value = pet.Hygene;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //TODO launch mini games menu.
            MinigamesMenu minigamesMenu = new MinigamesMenu();
            minigamesMenu.StartPosition = FormStartPosition.CenterParent;
            minigamesMenu.ShowDialog();
        }
    }
}
