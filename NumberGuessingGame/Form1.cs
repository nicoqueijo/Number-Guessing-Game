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
        private const string INVALID_INPUT = "Invalid input. Try entering a number.";
        private const string CONGRATS_MESSAGE = "Congratulations! You won!\nWould you like to play again?";
        private const string NUM_OUT_OF_RANGE = "Number out of range. Try a number between 1-100.";
        private const string RESTART = "Restart Game";
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
                    MessageBox.Show(NUM_OUT_OF_RANGE);
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
                else if (MessageBox.Show(CONGRATS_MESSAGE, RESTART, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
                MessageBox.Show(INVALID_INPUT);
            }
            else
            {
                // do nothing
            }
        }
    }
}
