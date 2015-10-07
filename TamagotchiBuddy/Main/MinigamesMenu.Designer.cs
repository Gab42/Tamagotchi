namespace Main
{
    partial class MinigamesMenu
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
            this.minigameButton1 = new System.Windows.Forms.Button();
            this.minigameButton4 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minigameButton5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minigameButton1
            // 
            this.minigameButton1.BackColor = System.Drawing.Color.Silver;
            this.minigameButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.minigameButton1.Location = new System.Drawing.Point(35, 52);
            this.minigameButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minigameButton1.Name = "minigameButton1";
            this.minigameButton1.Size = new System.Drawing.Size(141, 33);
            this.minigameButton1.TabIndex = 0;
            this.minigameButton1.Text = "TicTacToe";
            this.minigameButton1.UseVisualStyleBackColor = false;
            this.minigameButton1.Click += new System.EventHandler(this.minigameButton1_Click);
            // 
            // minigameButton4
            // 
            this.minigameButton4.BackColor = System.Drawing.Color.Silver;
            this.minigameButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.minigameButton4.Location = new System.Drawing.Point(35, 126);
            this.minigameButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minigameButton4.Name = "minigameButton4";
            this.minigameButton4.Size = new System.Drawing.Size(141, 33);
            this.minigameButton4.TabIndex = 3;
            this.minigameButton4.Text = "Match Two";
            this.minigameButton4.UseVisualStyleBackColor = false;
            this.minigameButton4.Click += new System.EventHandler(this.minigameButton4_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Silver;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cancelButton.Location = new System.Drawing.Point(35, 224);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(141, 33);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // minigameButton5
            // 
            this.minigameButton5.BackColor = System.Drawing.Color.Silver;
            this.minigameButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.minigameButton5.Location = new System.Drawing.Point(35, 89);
            this.minigameButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minigameButton5.Name = "minigameButton5";
            this.minigameButton5.Size = new System.Drawing.Size(141, 33);
            this.minigameButton5.TabIndex = 5;
            this.minigameButton5.Text = "Ballgame";
            this.minigameButton5.UseVisualStyleBackColor = false;
            this.minigameButton5.Click += new System.EventHandler(this.minigameButton5_Click);
            // 
            // MinigamesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(215, 270);
            this.Controls.Add(this.minigameButton5);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minigameButton4);
            this.Controls.Add(this.minigameButton1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MinigamesMenu";
            this.Text = "Minigames";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MinigamesMenu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button minigameButton1;
        private System.Windows.Forms.Button minigameButton4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button minigameButton5;
    }
}