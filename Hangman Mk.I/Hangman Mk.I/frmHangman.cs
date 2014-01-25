using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Mk.I
{
    public partial class frmHangman : Form
    {
        public frmHangman()
        {
            InitializeComponent();
        }

        Image image = Image.FromFile("images/hang1.gif");

        PictureBox pictureBox = new PictureBox();
        pictureBox.Image
    }
}
