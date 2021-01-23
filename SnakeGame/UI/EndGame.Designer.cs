namespace SnakeGame.UI
{
    partial class EndGame
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
            this.YourScoreLabel = new System.Windows.Forms.Label();
            this.YourScoreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YourNameTextBox = new System.Windows.Forms.TextBox();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YourScoreLabel
            // 
            this.YourScoreLabel.AutoSize = true;
            this.YourScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourScoreLabel.Location = new System.Drawing.Point(12, 76);
            this.YourScoreLabel.Name = "YourScoreLabel";
            this.YourScoreLabel.Size = new System.Drawing.Size(90, 20);
            this.YourScoreLabel.TabIndex = 0;
            this.YourScoreLabel.Text = "Your score:";
            // 
            // YourScoreTextBox
            // 
            this.YourScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourScoreTextBox.Location = new System.Drawing.Point(130, 73);
            this.YourScoreTextBox.Name = "YourScoreTextBox";
            this.YourScoreTextBox.ReadOnly = true;
            this.YourScoreTextBox.Size = new System.Drawing.Size(122, 26);
            this.YourScoreTextBox.TabIndex = 1;
            this.YourScoreTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your name:";
            // 
            // YourNameTextBox
            // 
            this.YourNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourNameTextBox.Location = new System.Drawing.Point(12, 32);
            this.YourNameTextBox.Name = "YourNameTextBox";
            this.YourNameTextBox.Size = new System.Drawing.Size(267, 26);
            this.YourNameTextBox.TabIndex = 3;
            // 
            // ReplayButton
            // 
            this.ReplayButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayButton.Location = new System.Drawing.Point(12, 162);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(86, 29);
            this.ReplayButton.TabIndex = 4;
            this.ReplayButton.Text = "Replay";
            this.ReplayButton.UseVisualStyleBackColor = false;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.Location = new System.Drawing.Point(172, 162);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(107, 29);
            this.MainMenuButton.TabIndex = 5;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 203);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.YourNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YourScoreTextBox);
            this.Controls.Add(this.YourScoreLabel);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EndGame_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YourScoreLabel;
        private System.Windows.Forms.TextBox YourScoreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YourNameTextBox;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Button MainMenuButton;
    }
}