﻿using System;
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
    }
}
