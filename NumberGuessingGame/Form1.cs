using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {

        private const int MAX_NUMBER = 100;
        private const int OFFSET = 1;
        private const string HIGHER = "Higher!";
        private const string LOWER = "Lower!";
        private int userGuess;
        private int attemps = 0;
        private int games = 1;

        private static Random rand = new Random();
        private int secretNumber = rand.Next(MAX_NUMBER) + OFFSET;

        public Form1()
        {
            InitializeComponent();
        }

        private void clickToPlayLabel_Click(object sender, EventArgs e)
        {
            gameGroupBox.Visible = true;
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(guessTextBox.Text, out userGuess))
            {
                if (userGuess < 1 || userGuess > 100)
                {
                    MessageBox.Show("Number out of range. Try a number between 1-100.");
                }
                else if (userGuess < secretNumber)
                {
                    attemps++;
                    attemptsValueLabel.Text = attemps.ToString();
                    hintValueLabel.Text = HIGHER;
                }
                else if (userGuess > secretNumber)
                {
                    attemps++;
                    attemptsValueLabel.Text = attemps.ToString();
                    hintValueLabel.Text = LOWER;
                }
                else if (MessageBox.Show("Congratulation! You won!\nWould you like to play again?", "Restart Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    attemps = 0;
                    attemptsValueLabel.Text = "";
                    gamesValueLabel.Text = games.ToString();
                    games++;
                    hintValueLabel.Text = "";
                    secretNumber = rand.Next(MAX_NUMBER) + OFFSET;
                }
                else
                {
                    this.Close();
                }

            }
            else if (guessTextBox.Text != "")
            {
                MessageBox.Show("Invalid input. Try entering a number.");
            }
            else
            {
                // do nothing
            }
        }
    }
}
