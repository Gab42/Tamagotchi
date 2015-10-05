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
            this.minigameButton2 = new System.Windows.Forms.Button();
            this.minigameButton3 = new System.Windows.Forms.Button();
            this.minigameButton4 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minigameButton5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minigameButton1
            // 
            this.minigameButton1.Location = new System.Drawing.Point(26, 23);
            this.minigameButton1.Margin = new System.Windows.Forms.Padding(2);
            this.minigameButton1.Name = "minigameButton1";
            this.minigameButton1.Size = new System.Drawing.Size(106, 27);
            this.minigameButton1.TabIndex = 0;
            this.minigameButton1.Text = "David - TicTacToe";
            this.minigameButton1.UseVisualStyleBackColor = true;
            this.minigameButton1.Click += new System.EventHandler(this.minigameButton1_Click);
            // 
            // minigameButton2
            // 
            this.minigameButton2.Location = new System.Drawing.Point(26, 149);
            this.minigameButton2.Margin = new System.Windows.Forms.Padding(2);
            this.minigameButton2.Name = "minigameButton2";
            this.minigameButton2.Size = new System.Drawing.Size(106, 27);
            this.minigameButton2.TabIndex = 1;
            this.minigameButton2.Text = "Rado";
            this.minigameButton2.UseVisualStyleBackColor = true;
            // 
            // minigameButton3
            // 
            this.minigameButton3.Location = new System.Drawing.Point(26, 86);
            this.minigameButton3.Margin = new System.Windows.Forms.Padding(2);
            this.minigameButton3.Name = "minigameButton3";
            this.minigameButton3.Size = new System.Drawing.Size(106, 27);
            this.minigameButton3.TabIndex = 2;
            this.minigameButton3.Text = "Gabi";
            this.minigameButton3.UseVisualStyleBackColor = true;
            // 
            // minigameButton4
            // 
            this.minigameButton4.Location = new System.Drawing.Point(26, 118);
            this.minigameButton4.Margin = new System.Windows.Forms.Padding(2);
            this.minigameButton4.Name = "minigameButton4";
            this.minigameButton4.Size = new System.Drawing.Size(106, 27);
            this.minigameButton4.TabIndex = 3;
            this.minigameButton4.Text = "Slav - Match Two";
            this.minigameButton4.UseVisualStyleBackColor = true;
            this.minigameButton4.Click += new System.EventHandler(this.minigameButton4_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(26, 182);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 27);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // minigameButton5
            // 
            this.minigameButton5.Location = new System.Drawing.Point(26, 54);
            this.minigameButton5.Margin = new System.Windows.Forms.Padding(2);
            this.minigameButton5.Name = "minigameButton5";
            this.minigameButton5.Size = new System.Drawing.Size(106, 27);
            this.minigameButton5.TabIndex = 5;
            this.minigameButton5.Text = "David2 - ballgame";
            this.minigameButton5.UseVisualStyleBackColor = true;
            this.minigameButton5.Click += new System.EventHandler(this.minigameButton5_Click);
            // 
            // MinigamesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 219);
            this.Controls.Add(this.minigameButton5);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minigameButton4);
            this.Controls.Add(this.minigameButton3);
            this.Controls.Add(this.minigameButton2);
            this.Controls.Add(this.minigameButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MinigamesMenu";
            this.Text = "Minigames";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button minigameButton1;
        private System.Windows.Forms.Button minigameButton2;
        private System.Windows.Forms.Button minigameButton3;
        private System.Windows.Forms.Button minigameButton4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button minigameButton5;
    }
}