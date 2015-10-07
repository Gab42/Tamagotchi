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
    public partial class MatchTwoGame : Form
    {
        public MatchTwoGame()
        {
            InitializeComponent();
        }

        bool buttonPressed = false;

        private void MatchTwoGame_Load(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Text != button7.Text)
            {
                button1.Text = "";
                button7.Text = "";
            }
            if (button2.Text != button10.Text)
            {
                button2.Text = "";
                button10.Text = "";
            }
            if (button3.Text != button5.Text)
            {
                button3.Text = "";
                button5.Text = "";
            }
            if (button4.Text != button12.Text)
            {
                button4.Text = "";
                button12.Text = "";
            }
            if (button6.Text != button8.Text)
            {
                button6.Text = "";
                button8.Text = "";
            }
            if (button9.Text != button11.Text)
            {
                button9.Text = "";
                button11.Text = "";
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Text = "SoftUni";
            
            if (button7.Text!="SoftUni" && buttonPressed)
            {
               
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Text = "Nakov";

            if (button10.Text != "Nakov" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button3.Text = "Dancho";

            if (button5.Text != "Dancho" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button4.Text = "C#";

            if (button12.Text != "C#" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button5.Text = "Dancho";

            if (button3.Text != "Dancho" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button6.Text = "Team Infers";

            if (button8.Text != "Team Infers" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button7.Text = "SoftUni";

            if (button1.Text != "SoftUni" && buttonPressed)
            {
               
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button8.Text = "Team Infers";

            if (button6.Text != "Team Infers" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button9.Text = "Team work";

            if (button11.Text != "Team work" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button10.Text = "Nakov";

            if (button2.Text != "Nakov" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button11.Text = "Team work";

            if (button9.Text != "Team work" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button12.Text = "C#";

            if (button4.Text != "C#" && buttonPressed)
            {
                timer1.Start();
            }
            buttonPressed = !buttonPressed;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           //unused
        }

        private void MatchTwoGame_MouseUp(object sender, MouseEventArgs e)
        {
            //unused
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button6.Text != "" && button9.Text != "")
            {
                MessageBox.Show("You have won!");
                Pet.Fun += 1;
                Close();
            }
            else
            {
                MessageBox.Show("You haven't won yet");
            }
        }
    }
}
