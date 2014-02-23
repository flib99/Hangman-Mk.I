//(c) Copyright Josh Walls 2014. All Rights Reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Hangman_Mk.I
{
    public partial class frmHangman : Form
    {
			DialogResult result = MessageBox.Show(			//Option to enable cheat mode. Useful for debugging
				"Do you want to enable cheat mode?",
				"Cheat Mode",
				MessageBoxButtons.YesNo);

        public frmHangman()
        {
            InitializeComponent();

            comboBoxLanguage.SelectedItem = "English";		//Sets the default language to English
			lblResult.Text = "";		//Removes 'Placeholder' from the dynamic labels
			lblWord.Text = "";
		}

        string word;		//The word to be guessed
        int wordsLength;		//The lenght of said word
        int lives = 10;		//Number of lives. I know it asks for 6 in the question but I feel 10 lives is better as it is incredibly difficult to win on 6 lives. Also the images I have dipicting the hangman's noose, there are 10 of them.
        char guess;		//The character that has just been guessed
        int randomNumber;		//Random number genorated to select the word
        string[] words = new string[] { };		//Array holding the dictionary
        char[] wordArray = new char[] { };		//The word to be guessed in a char array
		string wordCurrentGuess;		//The word with the stars representing letters

        private void btnLanguageGo_Click(object sender, EventArgs e)		//The go button on first tab
        {
            if (comboBoxLanguage.Text == "Debug")		//If the selected language is Debug (small dictionary for debugging purpouses). Same for every language
            {
                words = File.ReadAllLines("Resources/debug.txt");		//Reads all the lines of the dictionary into the word array
                wordsLength = words.Length;		//Finds the lenght of the word
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
                MessageBox.Show("Sorry, we don't have that language" + "\n" + "Select one from the list");		//If the langauge slected dosen't exist.
            }

			

			for (int i = 0; i < words.Length; i++)		//For every index in the word array
			{
				words[i] = words[i].ToUpper();		//Converts each index to uppercase
			}

            Random random = new Random();		//Declare new instance of Random called random
            randomNumber = random.Next(0, wordsLength);		//Genorates a new random number
            word = words[randomNumber];		//Selects the word at the index of the random number and stores it in word

			if (result == DialogResult.Yes)		//If cheat mode is enabled
			{
				MessageBox.Show("dictionary lenght: " + wordsLength + "\nrandom number selected: " + randomNumber + "\nword: " + word + "\n");		//Shows message box with the lenght of the dictionary, the random number selected and the word selected
			}

            wordArray = word.ToCharArray();		//Converts the word to a char array

            foreach(char c in word)		//For every letter in the word
            {
                lblWord.Text += "*";		//Places a star in lblWord for every letter in the word
            }

			tabControl1.SelectedIndex = 1;		//Moves to the next tab. The game tab
        }

        private void btnGuess_Click(object sender, EventArgs e)		//The guess button on the game tab
        {
            guess = Convert.ToChar(textBoxGuess.Text);		//The letter guessed converted to a char

            if (wordArray.Contains(guess))		//If the word contains the guessed letter
            {
				lblResult.Text = "Yes, " + guess + " is in the word!";		//Sets the label lblResult saying that the letter is the the word
				textBoxGuessedLetters.Text += guess + ", ";		//Adds the guessed letter to the Guessed letter textbox

				wordCurrentGuess = lblWord.Text;		//Sets the word label to the word with the stars in

				int result = 0;		//The location of guessed letter
				int foundLenght = 0;		
				string newChar = "";		//The letter to be replaced

				for (int i = 0; i < word.Length; i++)		//For every letter in the word
				{
					result = word.IndexOf(guess, foundLenght, word.Length - foundLenght);		//Find the location of the guessed letter

					if (result != -1)		//If the location is not -1. Should never be, validation
					{
						foundLenght = result + 1;		//Add one to the location of the letter

						newChar = word.Substring(result, 1);   //select the letter to be replaced

						wordCurrentGuess = wordCurrentGuess.Remove(result, 1);              //Remove the * character at this position

						wordCurrentGuess = wordCurrentGuess.Insert(result, newChar);        //insert the new character
					}
				}

				lblWord.Text = wordCurrentGuess;		//Replace the word label with the newly guessed letter in the word

				if (lblWord.Text.Contains("*") == false)		//If the word has no more stars in it
				{
					DialogResult playAgainResult = MessageBox.Show(		//Shows message box saying they they have won and if they want to play again
						"Congratulations, you won!\nDo you want to play again?",
						"Congratulations!",
						MessageBoxButtons.YesNo);
					if(playAgainResult == DialogResult.Yes)		//If they want to play again
					{
						lives = 10;		//Resets everything
						word = "";
						textBoxGuessedLetters.Text = "";
						textBoxGuess.Text = "";
						tabControl1.SelectedIndex = 0;
						lblWord.Text = "";
					}
					else		//If they don't want to play again
					{
						Application.Exit();		//Exit the application
					}
				}
            }
			else		//If the guessed letter is not in the word
            {
                lives = lives - 1;		//Removes a life

                textBoxGuessedLetters.Text += guess + ", ";		//Adds the guessed letter to the guesses letter textbox
				lblResult.Text = "Nope, " + guess + " is not in the word.";		//Tells you the letter is not in the word

                switch (lives)		//Switch case for the image depending on the number of lives
                {
                    case 0:		//When you have 0 lives
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang10;		//Display respective image
                        textBoxLives.Text = "0";		//Change lives text box to 0
                        MessageBox.Show(		//Show message box saying you got hanged and what the word was
                            "You got hanged! \nThe word was: " + word, 
                            "You're Dead!"
                        );

                        DialogResult playAgainResult = MessageBox.Show(		//Askes if you want to play again. Same process as before
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
                    case 1:		//When there is 1 life. Same for each number of lives
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang9;		//Displays respective image
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
		
		private void letterW_Click(object sender, EventArgs e)		//Letter W button. Same for each letter
		{
			textBoxGuess.Text = "W";		//Set guess letter in the guess textbox
			letterW.Enabled = false;		//Disables the button so you can't guess the letter again
		}

		private void letterDecimal_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = ".";
			letterDecimal.Enabled = false;
		}

		private void letterComma_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = ",";
			letterComma.Enabled = false;
		}

		private void letterX_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "X";
			letterX.Enabled = false;
		}

		private void letterU_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "U";
			letterU.Enabled = false;
		}

		private void letterS_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "S";
			letterS.Enabled = false;
		}

		private void letterR_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "R";
			letterR.Enabled = false;
		}

		private void letterQ_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "Q";
			letterQ.Enabled = false;
		}

		private void letterP_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "P";
			letterP.Enabled = false;
		}

		private void letterO_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "O";
			letterO.Enabled = false;
		}

		private void letterN_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "N";
			letterN.Enabled = false;
		}

		private void letterM_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "M";
			letterM.Enabled = false;
		}

		private void letterL_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "L";
			letterL.Enabled = false;
		}

		private void letterK_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "K";
			letterK.Enabled = false;
		}

		private void letterJ_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "J";
			letterJ.Enabled = false;
		}

		private void letterI_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "I";
			letterI.Enabled = false;
		}

		private void letterH_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "H";
			letterH.Enabled = false;
		}

		private void letterG_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "G";
			letterG.Enabled = false;
		}

		private void letterF_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "F";
			letterF.Enabled = false;
		}

		private void letterE_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "E";
			letterE.Enabled = false;
		}

		private void letterD_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "D";
			letterD.Enabled = false;
		}

		private void letterB_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "B";
			letterB.Enabled = false;
		}

		private void letterZ_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "Z";
			letterZ.Enabled = false;
		}

		private void letterY_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "Y";
			letterY.Enabled = false;
		}

		private void letterV_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "V";
			letterV.Enabled = false;
		}

		private void letterC_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "C";
			letterC.Enabled = false;
		}

		private void letterT_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "T";
			letterW.Enabled = false;
		}

		private void letterA_Click(object sender, EventArgs e)
		{
			textBoxGuess.Text = "A";
			letterA.Enabled = false;
		}

		private void btnSave_Click(object sender, EventArgs e)		//When the save button is clicked
		{
			SaveFileDialog save = new SaveFileDialog();		//Creates a new instance of a save file dialog called save
			save.FileName = textBoxNewWordSetName.Text + ".hangmanDictionary";		//The default file name to the name set in the textbox + .hangmanDictionary
			save.Filter = "Hangman Dictionary File|*.hangmanDictionary";		//Sets the filter to .hangmanDictionary
			if (save.ShowDialog() == DialogResult.OK)		//If ok is cliked in save
			{
				string saveFileName = save.FileName;		//Sets saveFileName as the saved filename for

				File.WriteAllLines(saveFileName, richTextBoxNewWordSet.Lines);		//Writes alllines in the richtextbox to the file
			}
		}

		private void btnOpen_Click(object sender, EventArgs e)		//When the open button is clicked
		{
			OpenFileDialog open = new OpenFileDialog();		//Creates new instance of an OpenFileDialog called open
			open.Filter = "Hangman Dictionary File|*.hangmanDictionary|All Files|*.*";		//Sets the filter to all files and .hangmanDictionary
			open.FilterIndex = 1;

			if (open.ShowDialog() == DialogResult.OK)		//If ok is clicked in open
			{
				words = File.ReadAllLines(open.FileName);		//Reads the contents of of thw file into thw word array

				for (int i = 0; i < words.Length; i++)		
				{
					words[i] = words[i].ToUpper();		//Converts all the indexes to uppercase
				}

				Random random = new Random();		//Same process as before
				randomNumber = random.Next(0, wordsLength);
				word = words[randomNumber];

				if (result == DialogResult.Yes)
				{
					Console.Write("dictionary lenght: " + wordsLength + "\nrandom number selected: " + randomNumber + "\nword: " + word + "\n");
				}

				wordArray = word.ToCharArray();

				foreach (char c in word)
				{
					lblWord.Text += "*";
				}
			}
		}   
    }
}
