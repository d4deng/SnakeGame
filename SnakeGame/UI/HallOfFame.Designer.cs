namespace SnakeGame.UI
{
    partial class HallOfFame
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
            this.FirstPlaceScoreTextBox = new System.Windows.Forms.TextBox();
            this.FirstPlaceLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FirstPlaceNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondPlaceNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondPlaceLabel = new System.Windows.Forms.Label();
            this.SecondPlaceScoreTextBox = new System.Windows.Forms.TextBox();
            this.ThirdPlaceNameTextBox = new System.Windows.Forms.TextBox();
            this.ThirdPlaceLabel = new System.Windows.Forms.Label();
            this.ThirdPlaceScoreTextBox = new System.Windows.Forms.TextBox();
            this.FourthPlaceNameTextBox = new System.Windows.Forms.TextBox();
            this.FourthPlaceLabel = new System.Windows.Forms.Label();
            this.FourthPlaceScoreTextBox = new System.Windows.Forms.TextBox();
            this.FifthPlaceNameTextBox = new System.Windows.Forms.TextBox();
            this.FifthPlaceLabel = new System.Windows.Forms.Label();
            this.FifthPlaceScoreTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstPlaceScoreTextBox
            // 
            this.FirstPlaceScoreTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FirstPlaceScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlaceScoreTextBox.Location = new System.Drawing.Point(78, 46);
            this.FirstPlaceScoreTextBox.Name = "FirstPlaceScoreTextBox";
            this.FirstPlaceScoreTextBox.Size = new System.Drawing.Size(76, 26);
            this.FirstPlaceScoreTextBox.TabIndex = 0;
            this.FirstPlaceScoreTextBox.Text = "1100";
            this.FirstPlaceScoreTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirstPlaceLabel
            // 
            this.FirstPlaceLabel.AutoSize = true;
            this.FirstPlaceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlaceLabel.Location = new System.Drawing.Point(13, 49);
            this.FirstPlaceLabel.Name = "FirstPlaceLabel";
            this.FirstPlaceLabel.Size = new System.Drawing.Size(34, 20);
            this.FirstPlaceLabel.TabIndex = 1;
            this.FirstPlaceLabel.Text = "1st";
            this.FirstPlaceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(88, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(56, 20);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Score";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(207, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // FirstPlaceNameTextBox
            // 
            this.FirstPlaceNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FirstPlaceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlaceNameTextBox.Location = new System.Drawing.Point(181, 46);
            this.FirstPlaceNameTextBox.Name = "FirstPlaceNameTextBox";
            this.FirstPlaceNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.FirstPlaceNameTextBox.TabIndex = 4;
            this.FirstPlaceNameTextBox.Text = "David";
            // 
            // SecondPlaceNameTextBox
            // 
            this.SecondPlaceNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SecondPlaceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlaceNameTextBox.Location = new System.Drawing.Point(181, 78);
            this.SecondPlaceNameTextBox.Name = "SecondPlaceNameTextBox";
            this.SecondPlaceNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.SecondPlaceNameTextBox.TabIndex = 7;
            this.SecondPlaceNameTextBox.Text = "David";
            // 
            // SecondPlaceLabel
            // 
            this.SecondPlaceLabel.AutoSize = true;
            this.SecondPlaceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SecondPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlaceLabel.Location = new System.Drawing.Point(13, 81);
            this.SecondPlaceLabel.Name = "SecondPlaceLabel";
            this.SecondPlaceLabel.Size = new System.Drawing.Size(39, 20);
            this.SecondPlaceLabel.TabIndex = 6;
            this.SecondPlaceLabel.Text = "2nd";
            // 
            // SecondPlaceScoreTextBox
            // 
            this.SecondPlaceScoreTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SecondPlaceScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlaceScoreTextBox.Location = new System.Drawing.Point(78, 78);
            this.SecondPlaceScoreTextBox.Name = "SecondPlaceScoreTextBox";
            this.SecondPlaceScoreTextBox.Size = new System.Drawing.Size(76, 26);
            this.SecondPlaceScoreTextBox.TabIndex = 5;
            this.SecondPlaceScoreTextBox.Text = "1100";
            // 
            // ThirdPlaceNameTextBox
            // 
            this.ThirdPlaceNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThirdPlaceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdPlaceNameTextBox.Location = new System.Drawing.Point(181, 110);
            this.ThirdPlaceNameTextBox.Name = "ThirdPlaceNameTextBox";
            this.ThirdPlaceNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.ThirdPlaceNameTextBox.TabIndex = 10;
            this.ThirdPlaceNameTextBox.Text = "David";
            // 
            // ThirdPlaceLabel
            // 
            this.ThirdPlaceLabel.AutoSize = true;
            this.ThirdPlaceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ThirdPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdPlaceLabel.Location = new System.Drawing.Point(13, 113);
            this.ThirdPlaceLabel.Name = "ThirdPlaceLabel";
            this.ThirdPlaceLabel.Size = new System.Drawing.Size(35, 20);
            this.ThirdPlaceLabel.TabIndex = 9;
            this.ThirdPlaceLabel.Text = "3rd";
            // 
            // ThirdPlaceScoreTextBox
            // 
            this.ThirdPlaceScoreTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThirdPlaceScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdPlaceScoreTextBox.Location = new System.Drawing.Point(78, 110);
            this.ThirdPlaceScoreTextBox.Name = "ThirdPlaceScoreTextBox";
            this.ThirdPlaceScoreTextBox.Size = new System.Drawing.Size(76, 26);
            this.ThirdPlaceScoreTextBox.TabIndex = 8;
            this.ThirdPlaceScoreTextBox.Text = "1100";
            // 
            // FourthPlaceNameTextBox
            // 
            this.FourthPlaceNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FourthPlaceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourthPlaceNameTextBox.Location = new System.Drawing.Point(181, 142);
            this.FourthPlaceNameTextBox.Name = "FourthPlaceNameTextBox";
            this.FourthPlaceNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.FourthPlaceNameTextBox.TabIndex = 13;
            this.FourthPlaceNameTextBox.Text = "David";
            // 
            // FourthPlaceLabel
            // 
            this.FourthPlaceLabel.AutoSize = true;
            this.FourthPlaceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FourthPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourthPlaceLabel.Location = new System.Drawing.Point(13, 145);
            this.FourthPlaceLabel.Name = "FourthPlaceLabel";
            this.FourthPlaceLabel.Size = new System.Drawing.Size(35, 20);
            this.FourthPlaceLabel.TabIndex = 12;
            this.FourthPlaceLabel.Text = "4th";
            // 
            // FourthPlaceScoreTextBox
            // 
            this.FourthPlaceScoreTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FourthPlaceScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourthPlaceScoreTextBox.Location = new System.Drawing.Point(78, 142);
            this.FourthPlaceScoreTextBox.Name = "FourthPlaceScoreTextBox";
            this.FourthPlaceScoreTextBox.Size = new System.Drawing.Size(76, 26);
            this.FourthPlaceScoreTextBox.TabIndex = 11;
            this.FourthPlaceScoreTextBox.Text = "1100";
            // 
            // FifthPlaceNameTextBox
            // 
            this.FifthPlaceNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FifthPlaceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FifthPlaceNameTextBox.Location = new System.Drawing.Point(181, 174);
            this.FifthPlaceNameTextBox.Name = "FifthPlaceNameTextBox";
            this.FifthPlaceNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.FifthPlaceNameTextBox.TabIndex = 16;
            this.FifthPlaceNameTextBox.Text = "David";
            // 
            // FifthPlaceLabel
            // 
            this.FifthPlaceLabel.AutoSize = true;
            this.FifthPlaceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FifthPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FifthPlaceLabel.Location = new System.Drawing.Point(13, 177);
            this.FifthPlaceLabel.Name = "FifthPlaceLabel";
            this.FifthPlaceLabel.Size = new System.Drawing.Size(35, 20);
            this.FifthPlaceLabel.TabIndex = 15;
            this.FifthPlaceLabel.Text = "5th";
            // 
            // FifthPlaceScoreTextBox
            // 
            this.FifthPlaceScoreTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FifthPlaceScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FifthPlaceScoreTextBox.Location = new System.Drawing.Point(78, 174);
            this.FifthPlaceScoreTextBox.Name = "FifthPlaceScoreTextBox";
            this.FifthPlaceScoreTextBox.Size = new System.Drawing.Size(76, 26);
            this.FifthPlaceScoreTextBox.TabIndex = 14;
            this.FifthPlaceScoreTextBox.Text = "1100";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(17, 429);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(264, 37);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // HallOfFame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 478);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.FifthPlaceNameTextBox);
            this.Controls.Add(this.FifthPlaceLabel);
            this.Controls.Add(this.FifthPlaceScoreTextBox);
            this.Controls.Add(this.FourthPlaceNameTextBox);
            this.Controls.Add(this.FourthPlaceLabel);
            this.Controls.Add(this.FourthPlaceScoreTextBox);
            this.Controls.Add(this.ThirdPlaceNameTextBox);
            this.Controls.Add(this.ThirdPlaceLabel);
            this.Controls.Add(this.ThirdPlaceScoreTextBox);
            this.Controls.Add(this.SecondPlaceNameTextBox);
            this.Controls.Add(this.SecondPlaceLabel);
            this.Controls.Add(this.SecondPlaceScoreTextBox);
            this.Controls.Add(this.FirstPlaceNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.FirstPlaceLabel);
            this.Controls.Add(this.FirstPlaceScoreTextBox);
            this.Name = "HallOfFame";
            this.Text = "Hall of Fame";
            this.Load += new System.EventHandler(this.HallOfFame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstPlaceScoreTextBox;
        private System.Windows.Forms.Label FirstPlaceLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox FirstPlaceNameTextBox;
        private System.Windows.Forms.TextBox SecondPlaceNameTextBox;
        private System.Windows.Forms.Label SecondPlaceLabel;
        private System.Windows.Forms.TextBox SecondPlaceScoreTextBox;
        private System.Windows.Forms.TextBox ThirdPlaceNameTextBox;
        private System.Windows.Forms.Label ThirdPlaceLabel;
        private System.Windows.Forms.TextBox ThirdPlaceScoreTextBox;
        private System.Windows.Forms.TextBox FourthPlaceNameTextBox;
        private System.Windows.Forms.Label FourthPlaceLabel;
        private System.Windows.Forms.TextBox FourthPlaceScoreTextBox;
        private System.Windows.Forms.TextBox FifthPlaceNameTextBox;
        private System.Windows.Forms.Label FifthPlaceLabel;
        private System.Windows.Forms.TextBox FifthPlaceScoreTextBox;
        private System.Windows.Forms.Button CloseButton;
    }
}