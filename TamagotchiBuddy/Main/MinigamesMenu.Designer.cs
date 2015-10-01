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
            this.SuspendLayout();
            // 
            // minigameButton1
            // 
            this.minigameButton1.Location = new System.Drawing.Point(35, 28);
            this.minigameButton1.Name = "minigameButton1";
            this.minigameButton1.Size = new System.Drawing.Size(142, 33);
            this.minigameButton1.TabIndex = 0;
            this.minigameButton1.Text = "David";
            this.minigameButton1.UseVisualStyleBackColor = true;
            // 
            // minigameButton2
            // 
            this.minigameButton2.Location = new System.Drawing.Point(35, 67);
            this.minigameButton2.Name = "minigameButton2";
            this.minigameButton2.Size = new System.Drawing.Size(142, 33);
            this.minigameButton2.TabIndex = 1;
            this.minigameButton2.Text = "Rado";
            this.minigameButton2.UseVisualStyleBackColor = true;
            // 
            // minigameButton3
            // 
            this.minigameButton3.Location = new System.Drawing.Point(35, 106);
            this.minigameButton3.Name = "minigameButton3";
            this.minigameButton3.Size = new System.Drawing.Size(142, 33);
            this.minigameButton3.TabIndex = 2;
            this.minigameButton3.Text = "Gabi";
            this.minigameButton3.UseVisualStyleBackColor = true;
            // 
            // minigameButton4
            // 
            this.minigameButton4.Location = new System.Drawing.Point(35, 145);
            this.minigameButton4.Name = "minigameButton4";
            this.minigameButton4.Size = new System.Drawing.Size(142, 33);
            this.minigameButton4.TabIndex = 3;
            this.minigameButton4.Text = "Slav";
            this.minigameButton4.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(35, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 33);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MinigamesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 269);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minigameButton4);
            this.Controls.Add(this.minigameButton3);
            this.Controls.Add(this.minigameButton2);
            this.Controls.Add(this.minigameButton1);
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
    }
}