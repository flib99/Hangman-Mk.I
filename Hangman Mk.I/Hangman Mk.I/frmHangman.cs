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


            StreamReader reader = new StreamReader("Resources/dictionary.txt");

            string fileString = "";
            int indexInteger = 0;

            string[] words = new string[] { };

            while (fileString != null)
            {
                fileString = reader.ReadLine();
                if (fileString != null)
                {
                    words[indexInteger] = fileString;
                }
            }
        }
    }
}
