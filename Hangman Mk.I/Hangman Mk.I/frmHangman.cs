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

namespace Hangman_Mk.I
{
    public partial class frmHangman : Form
    {
        public frmHangman()
        {
            InitializeComponent();

            comboBoxLanguage.SelectedItem = "English";

            //string[] words = File.ReadAllLines("Resources/dictionary.txt");

            //string[] words = new string[] { "hello", "goodbye" };

            //int wordsLength = words.Length;

            

            
        }

        int wordsLength;

        private void btnLanguageGo_Click(object sender, EventArgs e)
        {
            if (comboBoxLanguage.Text == "Afrikaans")
            {
                string[] words = File.ReadAllLines("Resources/afrikaans.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Belarusian")
            {
                string[] words = File.ReadAllLines("Resources/belarusian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Bulgarian")
            {
                string[] words = File.ReadAllLines("Resources/bulgarian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Catalan")
            {
                string[] words = File.ReadAllLines("Resources/catalan.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Croatian")
            {
                string[] words = File.ReadAllLines("Resources/croatian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Czech")
            {
                string[] words = File.ReadAllLines("Resources/czech.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Danish")
            {
                string[] words = File.ReadAllLines("Resources/danish.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Dutch")
            {
                string[] words = File.ReadAllLines("Resources/dutch.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "English")
            {
                string[] words = File.ReadAllLines("Resources/english.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "English (US)")
            {
                string[] words = File.ReadAllLines("Resources/american.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "French")
            {
                string[] words = File.ReadAllLines("Resources/french.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "German")
            {
                string[] words = File.ReadAllLines("Resources/german.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Greek")
            {
                string[] words = File.ReadAllLines("Resources/greek.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Hungarian")
            {
                string[] words = File.ReadAllLines("Resources/hungarian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Italian")
            {
                string[] words = File.ReadAllLines("Resources/italian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Latin")
            {
                string[] words = File.ReadAllLines("Resources/latin.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Mongolian")
            {
                string[] words = File.ReadAllLines("Resources/mongolian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Polish")
            {
                string[] words = File.ReadAllLines("Resources/polish.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Portuguese")
            {
                string[] words = File.ReadAllLines("Resources/portuguese.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Romanian")
            {
                string[] words = File.ReadAllLines("Resources/romanian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Russian")
            {
                string[] words = File.ReadAllLines("Resources/russian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Serbian")
            {
                string[] words = File.ReadAllLines("Resources/serbian.txt");
                wordsLength = words.Length;

            }
            else if (comboBoxLanguage.Text == "Slovak")
            {
                string[] words = File.ReadAllLines("Resources/slovak.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Slovenian")
            {
                string[] words = File.ReadAllLines("Resources/slovianian.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Spanish")
            {
                string[] words = File.ReadAllLines("Resources/spanish.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Swedish")
            {
                string[] words = File.ReadAllLines("Resources/swedish.txt");
                wordsLength = words.Length;
            }
            else if (comboBoxLanguage.Text == "Ukrainian")
            {
                string[] words = File.ReadAllLines("Resources/ukranian.txt");
                wordsLength = words.Length;
            }
            else
            {
                MessageBox.Show("Sorry, we don't have that language" + "\n" + "Select one from the list");
            }

            Console.WriteLine(wordsLength);
            //Console.ReadLine();
            
        }
    }
}
