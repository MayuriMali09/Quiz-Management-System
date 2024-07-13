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
    public partial class page52 : Form
    {
        int score;
        //private string correctans = "Public";
        string Username = "";
        string PRN = "";
        public page7(int previousscore, string Username, string PRN)
        {
            InitializeComponent();
            score = previousscore;
            this.Username = Username;
            this.PRN = PRN;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correctans = radioButton1.Text;
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
            page53 obj = new page8(score, Username, PRN);
            obj.Show();
            this.Hide();
        }
    }
}
