using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class MainGameUI : Form
    {
        Pet pet = new Pet();
      //  Image feed2 = ;

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
                for (int i = 0; i <= 4; i++)
                {
                    if (i%2 == 0)
                    {
                        petPicture.Image = Properties.Resources.hamsterfeed1;
                        petPicture.Refresh();
                    }
                    else
                    {
                        petPicture.Image = Properties.Resources.hamsterfeed2;
                        petPicture.Refresh();
                    }
                    Thread.Sleep(500);
                }
                pet.Hunger += 1;
                hungerBar.Value = pet.Hunger;

                petPicture.Image = Properties.Resources.hamsterfeed2;
                petPicture.Refresh();
                Thread.Sleep(500);               
                petPicture.Image = Properties.Resources.hamsterhappy;
                petPicture.Refresh();
                heartPicture.Image = Properties.Resources.heart;
                heartPicture.Refresh();
                Console.Beep(2800, 250);
                Thread.Sleep(1250);
                heartPicture.Image = null;
                heartPicture.Refresh();
                petPicture.Image = Properties.Resources.hamsterfeed2;
                petPicture.Refresh();

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
