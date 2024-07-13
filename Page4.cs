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
    public partial class Page4 : Form
    {
        int score;
         string correctans = "Class";
        string Username = "";
        string PRN = "";
        public Page4(int previousscore,string Username,string PRN)
        {
            InitializeComponent();
            this.Username = Username;
            this.PRN = PRN;
            score = previousscore;
            this.WindowState = FormWindowState.Maximized;
        }
        public Page4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked && radioButton1.Text == correctans)
            {
                score++;
            }
            else if (radioButton2.Checked && radioButton2.Text == correctans)
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
            Page5 obj = new Page5(score,Username,PRN);
            obj.Show();
            this.Hide();
        }
    }
}
