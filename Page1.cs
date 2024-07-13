using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizapp
{
    public partial class Page1 : Form
    {
          int score;
         string correctans = "Both A. and B.";
        string Username = "";
        string PRN = "";
        public Page1(string Username,string PRN)
        {
            InitializeComponent();
            this.Username = Username;
            this.PRN = PRN;
            this.WindowState = FormWindowState.Maximized;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked && radioButton1.Text == correctans)
            {
                score++;
            }
            else if(radioButton2.Checked && radioButton2.Text == correctans)
            {
                score++;
            }
            else if (radioButton3.Checked && radioButton3.Text == correctans)
            {
                score++;
            }
            else if (radioButton4.Checked && radioButton4.Text == correctans)
            {
                score++;
            }
            Page2 obj = new Page2(score,Username,PRN);
            obj.Show();
            this.Hide();
        }
    }
}
