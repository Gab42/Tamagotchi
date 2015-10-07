namespace Main
{
    partial class Ballgame
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
            this.Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Chartreuse;
            this.Score.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Score.Location = new System.Drawing.Point(-1, 332);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(379, 25);
            this.Score.TabIndex = 0;
            this.Score.Text = "SCORE :";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ballgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 354);
            this.Controls.Add(this.Score);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ballgame";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Score;
    }
}

