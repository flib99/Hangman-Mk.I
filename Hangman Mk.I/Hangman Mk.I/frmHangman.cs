using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Hangman_Mk.I
{
    public partial class frmHangman : Form
    {
			DialogResult result = MessageBox.Show(
				"Do you want to enable cheat mode?",
				"Cheat Mode",
				MessageBoxButtons.YesNo);

        public frmHangman()
        {
            InitializeComponent();

            comboBoxLanguage.SelectedItem = "Debug";
        }

        string word;
        int wordsLength;
        int lives = 10;
        char guess;
        int randomNumber;
        string[] words = new string[] { };
        char[] wordArray = new char[] { };
		char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
		string wordCurrentGuess;

        private void btnLanguageGo_Click(object sender, EventArgs e)
        {
            if (comboBoxLanguage.Text == "Debug")
            {
                words = File.ReadAllLines("Resources/debug.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Afrikaans")
            {
                words = File.ReadAllLines("Resources/afrikaans.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Belarusian")
            {
                words = File.ReadAllLines("Resources/belarusian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Bulgarian")
            {
                words = File.ReadAllLines("Resources/bulgarian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Catalan")
            {
                words = File.ReadAllLines("Resources/catalan.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Croatian")
            {
                words = File.ReadAllLines("Resources/croatian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Czech")
            {
                 words = File.ReadAllLines("Resources/czech.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Danish")
            {
                 words = File.ReadAllLines("Resources/danish.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Dutch")
            {
                 words = File.ReadAllLines("Resources/dutch.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "English")
            {
                 words = File.ReadAllLines("Resources/english.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "English (US)")
            {
                 words = File.ReadAllLines("Resources/american.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "French")
            {
                 words = File.ReadAllLines("Resources/french.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "German")
            {
                 words = File.ReadAllLines("Resources/german.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Greek")
            {
                 words = File.ReadAllLines("Resources/greek.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Hungarian")
            {
                 words = File.ReadAllLines("Resources/hungarian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Italian")
            {
                 words = File.ReadAllLines("Resources/italian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Latin")
            {
                 words = File.ReadAllLines("Resources/latin.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Mongolian")
            {
                 words = File.ReadAllLines("Resources/mongolian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Polish")
            {
                 words = File.ReadAllLines("Resources/polish.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Portuguese")
            {
                 words = File.ReadAllLines("Resources/portuguese.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Romanian")
            {
                 words = File.ReadAllLines("Resources/romanian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Russian")
            {
                 words = File.ReadAllLines("Resources/russian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Serbian")
            {
                 words = File.ReadAllLines("Resources/serbian.txt");
                wordsLength = words.Length;

            }
            else if (comboBoxLanguage.Text == "Slovak")
            {
                 words = File.ReadAllLines("Resources/slovak.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Slovenian")
            {
                 words = File.ReadAllLines("Resources/slovianian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Spanish")
            {
                 words = File.ReadAllLines("Resources/spanish.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Swedish")
            {
                 words = File.ReadAllLines("Resources/swedish.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Ukrainian")
            {
                 words = File.ReadAllLines("Resources/ukranian.txt");
                wordsLength = words.Length;
            }
            else
            {
                MessageBox.Show("Sorry, we don't have that language" + "\n" + "Select one from the list");
            }

			for (int i = 0; i < words.Length; i++)
			{
				words[i] = words[i].ToUpper();
			}

            Random random = new Random();
            randomNumber = random.Next(0, wordsLength);
            word = words[randomNumber];

			if (result == DialogResult.Yes)
			{
				Console.Write("dictionary lenght: " + wordsLength + "\nrandom number selected: " + randomNumber + "\nword: " + word);
			}

            wordArray = word.ToCharArray();

            foreach(char c in word)
            {
                lblWord.Text += "*";
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = Convert.ToChar(textBoxGuess.Text);

            if (wordArray.Contains(guess))
            {
				lblResult.Text = "Yes, " + guess + " is in the word!";
				textBoxGuessedLetters.Text += guess + ", ";

				wordCurrentGuess = lblWord.Text;

				int result = 0;
				int counter = 0;
				int foundLen = 0;
				string newChar = "";

				for (int i = 0; i < word.Length; i++)
				{
					result = word.IndexOf(guess, foundLen, word.Length - foundLen);

					if (result != -1)
					{
						foundLen = result + 1;
						counter++;

						newChar = word.Substring((result), 1);   //grab the letter to be replaced

						wordCurrentGuess = wordCurrentGuess.Remove(result, 1);              //Remove the * character at this position

						wordCurrentGuess = wordCurrentGuess.Insert(result, newChar);        //insert the new character
					}
				}

				lblWord.Text = wordCurrentGuess;

				if (lblWord.Text.Contains("*") == false)
				{
					DialogResult playAgainResult = MessageBox.Show(
						"Congratulations, you won!\nDo you want to play again?",
						"Congratulations!",
						MessageBoxButtons.YesNo);
					if(playAgainResult == DialogResult.Yes)
					{
						lives = 10;
						word = "";
						textBoxGuessedLetters.Text = "";
						textBoxGuess.Text = "";
						tabControl1.SelectedIndex = 0;
						lblWord.Text = "";
					}
					else
					{
						Application.Exit();
					}
				}
            }
            else
            {
                lives = lives - 1;

                textBoxGuessedLetters.Text += guess + ", ";
				lblResult.Text = "Nope, " + guess + " is not in the word.";

                switch (lives)
                {
                    case 0:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang10;
                        textBoxLives.Text = "0";
                        MessageBox.Show(
                            "You got hanged! \nThe word was: " + word, 
                            "You're Dead!"
                        );

                        DialogResult playAgainResult = MessageBox.Show(
                            "Do you want to play again?", 
                            "Play again", 
                            MessageBoxButtons.YesNo
                        );

                        if(playAgainResult == DialogResult.Yes)
                        {
                            lives = 10;
                            word = "";
                            textBoxGuessedLetters.Text = "";
                            textBoxGuess.Text = "";
                            tabControl1.SelectedIndex = 0;
							lblWord.Text = "";  
                        }
                        else
                        {
                            Application.Exit();
                        }
                            break;
                    case 1:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang9;
                            break;
                    case 2:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang8;
                            break;
                    case 3:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang7;
                            break;
                    case 4:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang6;
                            break;
                    case 5:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang5;
                            break;
                    case 6:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang4;
                            break;
                    case 7:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang3;
                            break;
                    case 8:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang2;
                            break;
                    case 9:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang1;
                            break;
                }
                textBoxLives.Text = Convert.ToString(lives);
            }
        }

		private void letterW_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "W";
		}

		private void letterDecimal_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = ".";
		}

		private void letterComma_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = ",";
		}

		private void letterX_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "X";
		}

		private void letterU_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "U";
		}

		private void letterS_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "";
		}

		private void letterR_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "R";
		}

		private void letterQ_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "Q";
		}

		private void letterP_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "P";
		}

		private void letterO_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "O";
		}

		private void letterN_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "N";
		}

		private void letterM_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "M";
		}

		private void letterL_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "L";
		}

		private void letterK_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "K";
		}

		private void letterJ_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "J";
		}

		private void letterI_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "I";
		}

		private void letterH_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "H";
		}

		private void letterG_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "G";
		}

		private void letterF_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "F";
		}

		private void letterE_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "E";
		}

		private void letterD_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "D";
		}

		private void letterB_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "B";
		}

		private void letterZ_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "Z";
		}

		private void letterY_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "Y";
		}

		private void letterV_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "V";
		}

		private void letterC_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "C";
		}

		private void letterT_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "T";
		}

		private void letterA_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "A";
		}   
    }
}
