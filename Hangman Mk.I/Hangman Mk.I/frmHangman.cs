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
        public frmHangman()
        {
            InitializeComponent();

            comboBoxLanguage.SelectedItem = "Debug";     
        }

        string word;
        int wordsLength;
        int lives = 11;
        char guess;
        int randomNumber;
        string[] words = new string[] { };
        char[] wordArray = new char[] { };

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

            Random random = new Random();
            randomNumber = random.Next(0, wordsLength);
            word = words[randomNumber];

            Console.WriteLine(wordsLength + " " + randomNumber + " " + word);

            wordArray = word.ToCharArray();

            foreach(char c in wordArray)
            {
                Console.WriteLine(c);
            }

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = Convert.ToChar(textBoxGuess.Text);

            if (wordArray.Contains(guess))
            {

            }
            else
            {
                lives = lives--;

                textBoxGuessedLetters.Text += guess + ", ";

                switch (lives)
                {
                    case 1:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang10;
                            break;
                    case 2:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang9;
                            break;
                    case 3:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang8;
                            break;
                    case 4:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang7;
                            break;
                    case 5:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang6;
                            break;
                    case 6:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang5;
                            break;
                    case 7:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang4;
                            break;
                    case 8:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang3;
                            break;
                    case 9:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang2;
                            break;
                    case 10:
                        pictureBoxHangman.Image = Hangman_Mk.I.Properties.Resources.hang1;
                            break;


                }
            }


        }
    }
}
