namespace NumberGuessingGame
{
    partial class Form1
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
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.clickToPlayLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.hintValueLabel = new System.Windows.Forms.Label();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.attemptsValueLabel = new System.Windows.Forms.Label();
            this.gamesLabel = new System.Windows.Forms.Label();
            this.gamesValueLabel = new System.Windows.Forms.Label();
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.gamesValueLabel);
            this.gameGroupBox.Controls.Add(this.gamesLabel);
            this.gameGroupBox.Controls.Add(this.attemptsValueLabel);
            this.gameGroupBox.Controls.Add(this.attemptsLabel);
            this.gameGroupBox.Controls.Add(this.hintValueLabel);
            this.gameGroupBox.Controls.Add(this.hintLabel);
            this.gameGroupBox.Controls.Add(this.guessButton);
            this.gameGroupBox.Controls.Add(this.guessTextBox);
            this.gameGroupBox.Location = new System.Drawing.Point(76, 101);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(271, 159);
            this.gameGroupBox.TabIndex = 0;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Try to guess the secret number (1-100)";
            this.gameGroupBox.Visible = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(142, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(131, 31);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(97, 30);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(64, 22);
            this.guessTextBox.TabIndex = 0;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(97, 58);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(64, 29);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Guess!";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // clickToPlayLabel
            // 
            this.clickToPlayLabel.AutoSize = true;
            this.clickToPlayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickToPlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickToPlayLabel.Location = new System.Drawing.Point(43, 55);
            this.clickToPlayLabel.Name = "clickToPlayLabel";
            this.clickToPlayLabel.Size = new System.Drawing.Size(333, 31);
            this.clickToPlayLabel.TabIndex = 2;
            this.clickToPlayLabel.Text = "Click here to begin playing!";
            this.clickToPlayLabel.Click += new System.EventHandler(this.clickToPlayLabel_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(94, 101);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(37, 17);
            this.hintLabel.TabIndex = 2;
            this.hintLabel.Text = "Hint:";
            // 
            // hintValueLabel
            // 
            this.hintValueLabel.AutoSize = true;
            this.hintValueLabel.Location = new System.Drawing.Point(139, 101);
            this.hintValueLabel.Name = "hintValueLabel";
            this.hintValueLabel.Size = new System.Drawing.Size(0, 17);
            this.hintValueLabel.TabIndex = 3;
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Location = new System.Drawing.Point(64, 118);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(67, 17);
            this.attemptsLabel.TabIndex = 4;
            this.attemptsLabel.Text = "Attempts:";
            // 
            // attemptsValueLabel
            // 
            this.attemptsValueLabel.AutoSize = true;
            this.attemptsValueLabel.Location = new System.Drawing.Point(139, 118);
            this.attemptsValueLabel.Name = "attemptsValueLabel";
            this.attemptsValueLabel.Size = new System.Drawing.Size(0, 17);
            this.attemptsValueLabel.TabIndex = 5;
            // 
            // gamesLabel
            // 
            this.gamesLabel.AutoSize = true;
            this.gamesLabel.Location = new System.Drawing.Point(28, 135);
            this.gamesLabel.Name = "gamesLabel";
            this.gamesLabel.Size = new System.Drawing.Size(103, 17);
            this.gamesLabel.TabIndex = 6;
            this.gamesLabel.Text = "Games played:";
            // 
            // gamesValueLabel
            // 
            this.gamesValueLabel.AutoSize = true;
            this.gamesValueLabel.Location = new System.Drawing.Point(139, 135);
            this.gamesValueLabel.Name = "gamesValueLabel";
            this.gamesValueLabel.Size = new System.Drawing.Size(0, 17);
            this.gamesValueLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 281);
            this.Controls.Add(this.clickToPlayLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.gameGroupBox);
            this.Name = "Form1";
            this.Text = "Number Guessing Game";
            this.gameGroupBox.ResumeLayout(false);
            this.gameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label clickToPlayLabel;
        private System.Windows.Forms.Label gamesValueLabel;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.Label attemptsValueLabel;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.Label hintValueLabel;
        private System.Windows.Forms.Label hintLabel;
    }
}

