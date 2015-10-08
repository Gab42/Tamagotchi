namespace Main
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
            ((System.ComponentModel.ISupportInitialize)(this.foodPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // hungerBar
            // 
            this.hungerBar.BackColor = System.Drawing.Color.Silver;
            this.hungerBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hungerBar.Location = new System.Drawing.Point(12, 12);
            this.hungerBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hungerBar.Maximum = 6;
            this.hungerBar.Name = "hungerBar";
            this.hungerBar.Size = new System.Drawing.Size(145, 32);
            this.hungerBar.Step = 1;
            this.hungerBar.TabIndex = 0;
            // 
            // tirednessBar
            // 
            this.tirednessBar.BackColor = System.Drawing.Color.Silver;
            this.tirednessBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tirednessBar.Location = new System.Drawing.Point(189, 12);
            this.tirednessBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tirednessBar.Maximum = 6;
            this.tirednessBar.Name = "tirednessBar";
            this.tirednessBar.Size = new System.Drawing.Size(145, 32);
            this.tirednessBar.Step = 1;
            this.tirednessBar.TabIndex = 1;
            // 
            // funBar
            // 
            this.funBar.BackColor = System.Drawing.Color.Silver;
            this.funBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.funBar.Location = new System.Drawing.Point(544, 12);
            this.funBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.funBar.Maximum = 6;
            this.funBar.Name = "funBar";
            this.funBar.Size = new System.Drawing.Size(145, 32);
            this.funBar.Step = 1;
            this.funBar.TabIndex = 3;
            // 
            // hygeneBar
            // 
            this.hygeneBar.BackColor = System.Drawing.Color.Silver;
            this.hygeneBar.ForeColor = System.Drawing.Color.White;
            this.hygeneBar.Location = new System.Drawing.Point(367, 12);
            this.hygeneBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hygeneBar.Maximum = 6;
            this.hygeneBar.Name = "hygeneBar";
            this.hygeneBar.Size = new System.Drawing.Size(145, 32);
            this.hygeneBar.Step = 1;
            this.hygeneBar.TabIndex = 2;
            // 
            // feedButton
            // 
            this.feedButton.BackColor = System.Drawing.Color.Silver;
            this.feedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.feedButton.Location = new System.Drawing.Point(12, 507);
            this.feedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(145, 46);
            this.feedButton.TabIndex = 5;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = false;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // sleepButton
            // 
            this.sleepButton.BackColor = System.Drawing.Color.Silver;
            this.sleepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.sleepButton.Location = new System.Drawing.Point(189, 507);
            this.sleepButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sleepButton.Name = "sleepButton";
            this.sleepButton.Size = new System.Drawing.Size(145, 46);
            this.sleepButton.TabIndex = 6;
            this.sleepButton.Text = "Lights Off";
            this.sleepButton.UseVisualStyleBackColor = false;
            this.sleepButton.Click += new System.EventHandler(this.sleepButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.BackColor = System.Drawing.Color.Silver;
            this.cleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cleanButton.Location = new System.Drawing.Point(367, 507);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(145, 46);
            this.cleanButton.TabIndex = 7;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = false;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Silver;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.playButton.Location = new System.Drawing.Point(544, 507);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(145, 46);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // cherryButton
            // 
            this.cherryButton.BackColor = System.Drawing.Color.Silver;
            this.cherryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cherryButton.Location = new System.Drawing.Point(12, 455);
            this.cherryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cherryButton.Name = "cherryButton";
            this.cherryButton.Size = new System.Drawing.Size(145, 46);
            this.cherryButton.TabIndex = 12;
            this.cherryButton.Text = "Cherry";
            this.cherryButton.UseVisualStyleBackColor = false;
            this.cherryButton.Visible = false;
            this.cherryButton.Click += new System.EventHandler(this.cherryButton_Click);
            // 
            // bananaButton
            // 
            this.bananaButton.BackColor = System.Drawing.Color.Silver;
            this.bananaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.bananaButton.Location = new System.Drawing.Point(12, 405);
            this.bananaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bananaButton.Name = "bananaButton";
            this.bananaButton.Size = new System.Drawing.Size(145, 46);
            this.bananaButton.TabIndex = 13;
            this.bananaButton.Text = "Banana";
            this.bananaButton.UseVisualStyleBackColor = false;
            this.bananaButton.Visible = false;
            this.bananaButton.Click += new System.EventHandler(this.bananaButton_Click);
            // 
            // appleButton
            // 
            this.appleButton.BackColor = System.Drawing.Color.Silver;
            this.appleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.appleButton.Location = new System.Drawing.Point(12, 354);
            this.appleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appleButton.Name = "appleButton";
            this.appleButton.Size = new System.Drawing.Size(145, 46);
            this.appleButton.TabIndex = 14;
            this.appleButton.Text = "Apple";
            this.appleButton.UseVisualStyleBackColor = false;
            this.appleButton.Visible = false;
            this.appleButton.Click += new System.EventHandler(this.appleButton_Click);
            // 
            // feedSecondClick
            // 
            this.feedSecondClick.BackColor = System.Drawing.Color.Silver;
            this.feedSecondClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.feedSecondClick.Location = new System.Drawing.Point(12, 507);
            this.feedSecondClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feedSecondClick.Name = "feedSecondClick";
            this.feedSecondClick.Size = new System.Drawing.Size(145, 46);
            this.feedSecondClick.TabIndex = 15;
            this.feedSecondClick.Text = "Feed";
            this.feedSecondClick.UseVisualStyleBackColor = false;
            this.feedSecondClick.Visible = false;
            this.feedSecondClick.Click += new System.EventHandler(this.feedSecondClick_Click);
            // 
            // foodPictureBox
            // 
            this.foodPictureBox.Location = new System.Drawing.Point(47, 162);
            this.foodPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodPictureBox.Name = "foodPictureBox";
            this.foodPictureBox.Size = new System.Drawing.Size(152, 145);
            this.foodPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.foodPictureBox.TabIndex = 11;
            this.foodPictureBox.TabStop = false;
            // 
            // heartPicture
            // 
            this.heartPicture.Location = new System.Drawing.Point(498, 161);
            this.heartPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heartPicture.Name = "heartPicture";
            this.heartPicture.Size = new System.Drawing.Size(154, 146);
            this.heartPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.heartPicture.TabIndex = 10;
            this.heartPicture.TabStop = false;
            // 
            // petPicture
            // 
            this.petPicture.Image = global::Main.Properties.Resources.hamsterfeed2;
            this.petPicture.Location = new System.Drawing.Point(221, 207);
            this.petPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.petPicture.Name = "petPicture";
            this.petPicture.Size = new System.Drawing.Size(253, 244);
            this.petPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.petPicture.TabIndex = 9;
            this.petPicture.TabStop = false;
            // 
            // energyTimer
            // 
            this.energyTimer.Interval = 7200000;
            this.energyTimer.Tick += new System.EventHandler(this.energyTimer_Tick);
            // 
            // MainGameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(693, 564);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}