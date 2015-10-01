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
            this.hungerBar = new System.Windows.Forms.ProgressBar();
            this.tirednessBar = new System.Windows.Forms.ProgressBar();
            this.funBar = new System.Windows.Forms.ProgressBar();
            this.hygeneBar = new System.Windows.Forms.ProgressBar();
            this.feedButton = new System.Windows.Forms.Button();
            this.sleepButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hungerBar
            // 
            this.hungerBar.Location = new System.Drawing.Point(12, 12);
            this.hungerBar.Maximum = 6;
            this.hungerBar.Name = "hungerBar";
            this.hungerBar.Size = new System.Drawing.Size(145, 32);
            this.hungerBar.Step = 1;
            this.hungerBar.TabIndex = 0;
            // 
            // tirednessBar
            // 
            this.tirednessBar.Location = new System.Drawing.Point(189, 12);
            this.tirednessBar.Maximum = 6;
            this.tirednessBar.Name = "tirednessBar";
            this.tirednessBar.Size = new System.Drawing.Size(145, 32);
            this.tirednessBar.Step = 1;
            this.tirednessBar.TabIndex = 1;
            // 
            // funBar
            // 
            this.funBar.Location = new System.Drawing.Point(544, 12);
            this.funBar.Maximum = 6;
            this.funBar.Name = "funBar";
            this.funBar.Size = new System.Drawing.Size(145, 32);
            this.funBar.Step = 1;
            this.funBar.TabIndex = 3;
            // 
            // hygeneBar
            // 
            this.hygeneBar.Location = new System.Drawing.Point(367, 12);
            this.hygeneBar.Maximum = 6;
            this.hygeneBar.Name = "hygeneBar";
            this.hygeneBar.Size = new System.Drawing.Size(145, 32);
            this.hygeneBar.Step = 1;
            this.hygeneBar.TabIndex = 2;
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(12, 507);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(145, 45);
            this.feedButton.TabIndex = 5;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // sleepButton
            // 
            this.sleepButton.Location = new System.Drawing.Point(189, 507);
            this.sleepButton.Name = "sleepButton";
            this.sleepButton.Size = new System.Drawing.Size(145, 45);
            this.sleepButton.TabIndex = 6;
            this.sleepButton.Text = "Lights off";
            this.sleepButton.UseVisualStyleBackColor = true;
            this.sleepButton.Click += new System.EventHandler(this.sleepButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(367, 507);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(145, 45);
            this.cleanButton.TabIndex = 7;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(544, 507);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(145, 45);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // MainGameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 564);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.sleepButton);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.funBar);
            this.Controls.Add(this.hygeneBar);
            this.Controls.Add(this.tirednessBar);
            this.Controls.Add(this.hungerBar);
            this.Name = "MainGameUI";
            this.Text = "Tamagotchi Buddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGameUI_FormClosing);
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
    }
}