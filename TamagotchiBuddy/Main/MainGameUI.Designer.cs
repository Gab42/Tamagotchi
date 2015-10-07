﻿namespace Main
{
    partial class MainGameUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hungerBar = new System.Windows.Forms.ProgressBar();
            this.tirednessBar = new System.Windows.Forms.ProgressBar();
            this.funBar = new System.Windows.Forms.ProgressBar();
            this.hygeneBar = new System.Windows.Forms.ProgressBar();
            this.feedButton = new System.Windows.Forms.Button();
            this.sleepButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.cherryButton = new System.Windows.Forms.Button();
            this.bananaButton = new System.Windows.Forms.Button();
            this.appleButton = new System.Windows.Forms.Button();
            this.feedSecondClick = new System.Windows.Forms.Button();
            this.foodPictureBox = new System.Windows.Forms.PictureBox();
            this.heartPicture = new System.Windows.Forms.PictureBox();
            this.petPicture = new System.Windows.Forms.PictureBox();
            this.energyTimer = new System.Windows.Forms.Timer(this.components);
            this.hygeneTimer = new System.Windows.Forms.Timer(this.components);
            this.hungerTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.foodPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // hungerBar
            // 
            this.hungerBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hungerBar.Location = new System.Drawing.Point(9, 10);
            this.hungerBar.Margin = new System.Windows.Forms.Padding(2);
            this.hungerBar.Maximum = 6;
            this.hungerBar.Name = "hungerBar";
            this.hungerBar.Size = new System.Drawing.Size(109, 26);
            this.hungerBar.Step = 1;
            this.hungerBar.TabIndex = 0;
            // 
            // tirednessBar
            // 
            this.tirednessBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tirednessBar.Location = new System.Drawing.Point(142, 10);
            this.tirednessBar.Margin = new System.Windows.Forms.Padding(2);
            this.tirednessBar.Maximum = 6;
            this.tirednessBar.Name = "tirednessBar";
            this.tirednessBar.Size = new System.Drawing.Size(109, 26);
            this.tirednessBar.Step = 1;
            this.tirednessBar.TabIndex = 1;
            // 
            // funBar
            // 
            this.funBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.funBar.Location = new System.Drawing.Point(408, 10);
            this.funBar.Margin = new System.Windows.Forms.Padding(2);
            this.funBar.Maximum = 6;
            this.funBar.Name = "funBar";
            this.funBar.Size = new System.Drawing.Size(109, 26);
            this.funBar.Step = 1;
            this.funBar.TabIndex = 3;
            // 
            // hygeneBar
            // 
            this.hygeneBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hygeneBar.Location = new System.Drawing.Point(275, 10);
            this.hygeneBar.Margin = new System.Windows.Forms.Padding(2);
            this.hygeneBar.Maximum = 6;
            this.hygeneBar.Name = "hygeneBar";
            this.hygeneBar.Size = new System.Drawing.Size(109, 26);
            this.hygeneBar.Step = 1;
            this.hygeneBar.TabIndex = 2;
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(9, 412);
            this.feedButton.Margin = new System.Windows.Forms.Padding(2);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(109, 37);
            this.feedButton.TabIndex = 5;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // sleepButton
            // 
            this.sleepButton.Location = new System.Drawing.Point(142, 412);
            this.sleepButton.Margin = new System.Windows.Forms.Padding(2);
            this.sleepButton.Name = "sleepButton";
            this.sleepButton.Size = new System.Drawing.Size(109, 37);
            this.sleepButton.TabIndex = 6;
            this.sleepButton.Text = "Lights Off";
            this.sleepButton.UseVisualStyleBackColor = true;
            this.sleepButton.Click += new System.EventHandler(this.sleepButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(275, 412);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(2);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(109, 37);
            this.cleanButton.TabIndex = 7;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(408, 412);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(109, 37);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // cherryButton
            // 
            this.cherryButton.Location = new System.Drawing.Point(9, 370);
            this.cherryButton.Margin = new System.Windows.Forms.Padding(2);
            this.cherryButton.Name = "cherryButton";
            this.cherryButton.Size = new System.Drawing.Size(109, 37);
            this.cherryButton.TabIndex = 12;
            this.cherryButton.Text = "Cherry";
            this.cherryButton.UseVisualStyleBackColor = true;
            this.cherryButton.Visible = false;
            this.cherryButton.Click += new System.EventHandler(this.cherryButton_Click);
            // 
            // bananaButton
            // 
            this.bananaButton.Location = new System.Drawing.Point(9, 329);
            this.bananaButton.Margin = new System.Windows.Forms.Padding(2);
            this.bananaButton.Name = "bananaButton";
            this.bananaButton.Size = new System.Drawing.Size(109, 37);
            this.bananaButton.TabIndex = 13;
            this.bananaButton.Text = "Banana";
            this.bananaButton.UseVisualStyleBackColor = true;
            this.bananaButton.Visible = false;
            this.bananaButton.Click += new System.EventHandler(this.bananaButton_Click);
            // 
            // appleButton
            // 
            this.appleButton.Location = new System.Drawing.Point(9, 288);
            this.appleButton.Margin = new System.Windows.Forms.Padding(2);
            this.appleButton.Name = "appleButton";
            this.appleButton.Size = new System.Drawing.Size(109, 37);
            this.appleButton.TabIndex = 14;
            this.appleButton.Text = "Apple";
            this.appleButton.UseVisualStyleBackColor = true;
            this.appleButton.Visible = false;
            this.appleButton.Click += new System.EventHandler(this.appleButton_Click);
            // 
            // feedSecondClick
            // 
            this.feedSecondClick.Location = new System.Drawing.Point(9, 412);
            this.feedSecondClick.Margin = new System.Windows.Forms.Padding(2);
            this.feedSecondClick.Name = "feedSecondClick";
            this.feedSecondClick.Size = new System.Drawing.Size(109, 37);
            this.feedSecondClick.TabIndex = 15;
            this.feedSecondClick.Text = "Feed";
            this.feedSecondClick.UseVisualStyleBackColor = true;
            this.feedSecondClick.Visible = false;
            this.feedSecondClick.Click += new System.EventHandler(this.feedSecondClick_Click);
            // 
            // foodPictureBox
            // 
            this.foodPictureBox.Location = new System.Drawing.Point(56, 141);
            this.foodPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.foodPictureBox.Name = "foodPictureBox";
            this.foodPictureBox.Size = new System.Drawing.Size(105, 108);
            this.foodPictureBox.TabIndex = 11;
            this.foodPictureBox.TabStop = false;
            // 
            // heartPicture
            // 
            this.heartPicture.Location = new System.Drawing.Point(353, 141);
            this.heartPicture.Margin = new System.Windows.Forms.Padding(2);
            this.heartPicture.Name = "heartPicture";
            this.heartPicture.Size = new System.Drawing.Size(105, 108);
            this.heartPicture.TabIndex = 10;
            this.heartPicture.TabStop = false;
            // 
            // petPicture
            // 
            this.petPicture.Image = global::Main.Properties.Resources.hamsterfeed2;
            this.petPicture.Location = new System.Drawing.Point(185, 210);
            this.petPicture.Margin = new System.Windows.Forms.Padding(2);
            this.petPicture.Name = "petPicture";
            this.petPicture.Size = new System.Drawing.Size(141, 148);
            this.petPicture.TabIndex = 9;
            this.petPicture.TabStop = false;
            // 
            // energyTimer
            // 
            this.energyTimer.Interval = 3600000;
            this.energyTimer.Tick += new System.EventHandler(this.energyTimer_Tick);
            // 
            // hygeneTimer
            // 
            this.hygeneTimer.Interval = 3600000;
            this.hygeneTimer.Tick += new System.EventHandler(this.hygeneTimer_Tick);
            // 
            // hungerTimer
            // 
            this.hungerTimer.Interval = 3600000;
            this.hungerTimer.Tick += new System.EventHandler(this.hungerTimer_Tick);
            // 
            // MainGameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 458);
            this.Controls.Add(this.feedSecondClick);
            this.Controls.Add(this.appleButton);
            this.Controls.Add(this.bananaButton);
            this.Controls.Add(this.cherryButton);
            this.Controls.Add(this.foodPictureBox);
            this.Controls.Add(this.heartPicture);
            this.Controls.Add(this.petPicture);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.sleepButton);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.funBar);
            this.Controls.Add(this.hygeneBar);
            this.Controls.Add(this.tirednessBar);
            this.Controls.Add(this.hungerBar);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainGameUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamagotchi Buddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGameUI_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGameUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.foodPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar hungerBar;
        private System.Windows.Forms.ProgressBar tirednessBar;
        private System.Windows.Forms.ProgressBar funBar;
        private System.Windows.Forms.ProgressBar hygeneBar;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.Button sleepButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox petPicture;
        private System.Windows.Forms.PictureBox heartPicture;
        private System.Windows.Forms.PictureBox foodPictureBox;
        private System.Windows.Forms.Button cherryButton;
        private System.Windows.Forms.Button bananaButton;
        private System.Windows.Forms.Button appleButton;
        private System.Windows.Forms.Button feedSecondClick;
        private System.Windows.Forms.Timer energyTimer;
        private System.Windows.Forms.Timer hygeneTimer;
        private System.Windows.Forms.Timer hungerTimer;
    }
}