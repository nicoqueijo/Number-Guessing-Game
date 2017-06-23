using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Nicolas Queijo

/// <summary>
/// In this number-guessing game, the user will enter a number between 1 and 100
/// to try to guess a secret value. The program will answer with one of three possible
/// responses: Either the number is too low, it is too high, or it is the secret number.
/// </summary>
namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        private const int MIN_NUMBER = 1;
        private const int MAX_NUMBER = 100;
        private const int OFFSET = 1;
        private const string HIGHER = "Higher!";
        private const string LOWER = "Lower!";
        private const string INVALID_INPUT = "Invalid input. Try entering an integer.";
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

        /// <summary>
        /// The main controls for the game become visible once the user clicks on the play button.
        /// </summary>
        /// <param name="sender">Unused but required</param>
        /// <param name="e">Unused but required</param>
        private void clickToPlayLabel_Click(object sender, EventArgs e)
        {
            gameGroupBox.Visible = true;
        }

        /// <summary>
        /// This button is responsible for validating user input and determining if the game is
        /// won. It begins by checking if the user entered an integer. If that is not the case
        /// the user is notified and asked to enter an integer. When the user finally enters an
        /// integer it is checked to see if it falls within the permitted range of 1-100. If this
        /// is not the case the user is notified and asked to re-enter an integer in the permitted
        /// range. Once the user entered an integer in the permitted range it is tested to see if
        /// the number is less, greater, or equal to the secret number. If it is less/greater the
        /// program tells the user that the secret number is lower/higher and the attempts variable
        /// is incremented. If the user's number is equal to the secret number a message is shown
        /// informing the user he/she won and is prompted to exit or play again. If the user decides
        /// to play again the number-of-games variable is incremented and a new secret number is 
        /// generated for the new game.
        /// </summary>
        /// <param name="sender">Unused but required</param>
        /// <param name="e">Unused but required</param>
        private void guessButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(guessTextBox.Text, out userGuess))
            {
                if (userGuess < MIN_NUMBER || userGuess > MAX_NUMBER)
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
                else if (MessageBox.Show(CONGRATS_MESSAGE, RESTART, MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
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
        }
    }
}
