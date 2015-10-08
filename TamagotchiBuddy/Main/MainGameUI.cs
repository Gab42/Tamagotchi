using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Main
{
    public partial class MainGameUI : Form
    {
        public MainGameUI()
        {
            InitializeComponent();

            // Set stats.  
            hungerBar.Value = Pet.Hunger;
            tirednessBar.Value = Pet.Tiredness;
            hygeneBar.Value = Pet.Hygene;
            funBar.Value = Pet.Fun;

            energyTimer.Start();
        }

        // Happy animation.
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
            petPicture.Image = Properties.Resources.hamsterfeed2;
            petPicture.Refresh();
        }

        // Disable buttons (used while animations are running).
        public void DisableAllButtons()
        {
            cleanButton.Enabled = false;
            playButton.Enabled = false;
            sleepButton.Enabled = false;
        }

        // Enable buttons (after animations).
        public void EnableAllButtons()
        {
            cleanButton.Enabled = true;
            playButton.Enabled = true;
            sleepButton.Enabled = true;
        }

        private void FoodMenuVisibility(bool visibility)
        {
            bananaButton.Visible = visibility;
            appleButton.Visible = visibility;
            cherryButton.Visible = visibility;
        }

        // Exit.
        private void MainGameUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            energyTimer.Stop();
            Pet.SaveGame();
        }

        // Quit with Esc key.
        private void MainGameUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "27")
            {
                this.Close();
            }
        }

        // Feeding.
        // Show food types menu.
        private void feedButton_Click(object sender, EventArgs e)
        {
            FoodMenuVisibility(true);
            feedSecondClick.Visible = true;
            feedButton.Visible = false;
            DisableAllButtons();
        }

        // Hide food types menu.
        private void feedSecondClick_Click(object sender, EventArgs e)
        {
            EnableAllButtons();
            FoodMenuVisibility(false);
            feedSecondClick.Visible = false;
            feedButton.Visible = true;
        }

        // Feed chosen type of food.
        private void cherryButton_Click(object sender, EventArgs e)
        {
            Feed("cherry");
        }

        private void bananaButton_Click(object sender, EventArgs e)
        {
            Feed("banana");
        }

        private void appleButton_Click(object sender, EventArgs e)
        {
            Feed("apple");
        }

        // Feeding animation.
        private void Feed(string type)
        {
            FoodMenuVisibility(false);
            feedSecondClick.Enabled = false;

            if (Pet.Hunger < hungerBar.Maximum)
            {
                string food1 = type + "1";
                string food2 = type + "2";
                string food3 = type + "3";

                foodPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(food1);
                foodPictureBox.Visible = true;
                foodPictureBox.Refresh();

                for (int i = 0; i <= 4; i++)
                {
                    if (i % 2 == 0)
                    {
                        petPicture.Image = Properties.Resources.hamsterfeed1;
                        petPicture.Refresh();
                    }
                    else
                    {
                        petPicture.Image = Properties.Resources.hamsterfeed2;
                        petPicture.Refresh();
                        if (i == 1)
                        {
                            foodPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(food2);
                            foodPictureBox.Refresh();
                        }
                        else if (i == 3)
                        {
                            foodPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(food3);
                            foodPictureBox.Refresh();
                        }
                    }
                    Thread.Sleep(500);
                }

                Pet.Hunger += 1;
                hungerBar.Value = Pet.Hunger;

                petPicture.Image = Properties.Resources.hamsterfeed2;
                petPicture.Refresh();
                foodPictureBox.Visible = false;
                foodPictureBox.Refresh();
                Thread.Sleep(500);
                PetHappy();
            }

            feedSecondClick.Enabled = true;
            EnableAllButtons();
            feedSecondClick.Visible = false;
            feedButton.Visible = true;
        }

        // Sleeping.
        private void sleepButton_Click(object sender, EventArgs e)
        {
            Pet.SleepFlag = !Pet.SleepFlag;
            if (Pet.SleepFlag)
            {
                petPicture.Image = Properties.Resources.hamstersleep;
                petPicture.Refresh();
                heartPicture.Image = Properties.Resources.sleep;
                heartPicture.Refresh();

                DisableAllButtons();
                feedButton.Enabled = false;
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
                feedButton.Enabled = true;
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

                Pet.Hygene = hygeneBar.Maximum;
                hygeneBar.Value = Pet.Hygene;

                PetHappy();
                EnableAllButtons();
            }
        }

        // Launch Minigames menu.
        private void playButton_Click(object sender, EventArgs e)
        {
            MinigamesMenu minigamesMenu = new MinigamesMenu();
            minigamesMenu.StartPosition = FormStartPosition.CenterParent;
            minigamesMenu.ShowDialog();
            if (funBar.Value != Pet.Fun)
            {
                PetHappy();
                funBar.Value = Pet.Fun;
            }
        }

        //Stat decay timers
        private void energyTimer_Tick(object sender, EventArgs e)
        {
            if (Pet.Tiredness >= 1 && Pet.SleepFlag == false)
            {
                Pet.Tiredness--;
            }
            else
            {
                if (Pet.Tiredness < 6 && Pet.SleepFlag == true)
                {
                    Pet.Tiredness++;
                }
            }

            if (Pet.Hygene >= 1)
            {
                Pet.Hygene--;
            }

            if (Pet.Hunger >= 1)
            {
                Pet.Hunger--;
            }

            if (Pet.Fun >= 1)
            {
                Pet.Fun--;
            }

            hungerBar.Value = Pet.Hunger;
            tirednessBar.Value = Pet.Tiredness;
            hygeneBar.Value = Pet.Hygene;
            funBar.Value = Pet.Fun;
        }
    }
}
