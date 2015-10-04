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
        
        bool sleepFlag = false;


        public MainGameUI()
        {
            InitializeComponent();
            // Set stats.  
            hungerBar.Value = Pet.Hunger;
            tirednessBar.Value = Pet.Tiredness;
            hygeneBar.Value = Pet.Hygene;
            funBar.Value = Pet.Fun;
           
        }

        private void MainGameUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO save before exiting.
            // Exit.
            Application.Exit();
        }

        // Feeding.
        private void feedButton_Click(object sender, EventArgs e)
        {
            if (Pet.Hunger < hungerBar.Maximum)
            {
                DisableAllButtons();
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
                Pet.Hunger += 1;
                hungerBar.Value = Pet.Hunger;

                petPicture.Image = Properties.Resources.hamsterfeed2;
                petPicture.Refresh();
                Thread.Sleep(500);
                PetHappy();
                petPicture.Image = Properties.Resources.hamsterfeed2;
                petPicture.Refresh();
                EnableAllButtons();
            }
        }

        // Sleeping.
        private void sleepButton_Click(object sender, EventArgs e)
        {
            //TODO - pet tiredness bar should start going up slowly.

            sleepFlag = !sleepFlag;
            if (sleepFlag)
            {
                petPicture.Image = Properties.Resources.hamstersleep;
                petPicture.Refresh();
                heartPicture.Image = Properties.Resources.sleep;
                heartPicture.Refresh();
                DisableAllButtons();
                sleepButton.Enabled = true;
                sleepButton.Text = "Lights On";
            }
            else
            {
                petPicture.Image = Properties.Resources.hamsterfeed2;
                petPicture.Refresh();
                heartPicture.Image = null;
                heartPicture.Refresh();

                EnableAllButtons();
                sleepButton.Text = "Lights Off";
            }
        }

        // Cleaning.
        private void cleanButton_Click(object sender, EventArgs e)
        {
            if (Pet.Hygene < hygeneBar.Maximum)
            {
                DisableAllButtons();           
                petPicture.Image = Properties.Resources.hamsterclean;
                petPicture.Refresh();
                heartPicture.Image = Properties.Resources.brush;
                heartPicture.Refresh();
                int topCoord = heartPicture.Top;
                int leftCoord = heartPicture.Left;
                for (int i = 0; i <= 4; i++)
                {
                    if (i % 2 == 0)
                    {
                        heartPicture.Top = topCoord - 20;
                        heartPicture.Left = leftCoord - 20;
                        heartPicture.Top = topCoord - 10;
                        heartPicture.Left = leftCoord - 10;
                        heartPicture.Top = topCoord;
                        heartPicture.Left = leftCoord;                  
                    }
                    else
                    {
                        heartPicture.Top = topCoord - 10;
                        heartPicture.Left = leftCoord - 10;
                        heartPicture.Top = topCoord - 20;
                        heartPicture.Left = leftCoord - 20;
                        heartPicture.Top = topCoord - 30;
                        heartPicture.Left = leftCoord - 30;
                    }
                    Thread.Sleep(500);
                }

                Pet.Hygene += 1;
                hygeneBar.Value = Pet.Hygene;

                PetHappy();
                petPicture.Image = Properties.Resources.hamsterfeed2;
                petPicture.Refresh();
                EnableAllButtons();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //TODO launch mini games menu.
            MinigamesMenu minigamesMenu = new MinigamesMenu();
            minigamesMenu.StartPosition = FormStartPosition.CenterParent;
            minigamesMenu.ShowDialog();
            funBar.Value = Pet.Fun;
        }

        public void PetHappy()
        {
            petPicture.Image = Properties.Resources.hamsterhappy;
            petPicture.Refresh();
            heartPicture.Image = Properties.Resources.heart;
            heartPicture.Refresh();
            Console.Beep(2700, 250);
            Thread.Sleep(1250);
            heartPicture.Image = null;
            heartPicture.Refresh();
        }

        public void DisableAllButtons()
        {
            feedButton.Enabled = false;
            cleanButton.Enabled = false;
            playButton.Enabled = false;
            sleepButton.Enabled = false;
        }

        public void EnableAllButtons()
        {
            feedButton.Enabled = true;
            cleanButton.Enabled = true;
            playButton.Enabled = true;
            sleepButton.Enabled = true;
        }
    }
}
