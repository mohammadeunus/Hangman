using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_v2
{
    public partial class Form3 : Form
    {
        public Form3(string end, bool win)
        {

            String[] finalmsg = new String[] { "CONGRATULATION", "GAME OVER" };
            InitializeComponent();
            if (win == true)
            {
                GAMEOVER.Text = finalmsg[0];
                mystryWord.Text = "WORD MATCHED";
            }
            else
            {
                GAMEOVER.Text = finalmsg[1];
                mystryWord.Text = "the mysteryWord is " + end;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mystryWord2_Click(object sender, EventArgs e)
        {

        }
    }
}
