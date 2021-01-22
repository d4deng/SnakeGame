namespace SnakeGame.UI
{
    partial class GameBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 0;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(61, 20);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score:";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTextBox.Location = new System.Drawing.Point(79, 6);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.ReadOnly = true;
            this.ScoreTextBox.Size = new System.Drawing.Size(100, 26);
            this.ScoreTextBox.TabIndex = 2;
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(578, 6);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(109, 27);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.Location = new System.Drawing.Point(693, 6);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(119, 27);
            this.MainMenuButton.TabIndex = 4;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 641);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.panel1);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button MainMenuButton;
    }
}