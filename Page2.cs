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
    public partial class Page2 : Form
    {
         int score;
         string correctans = "int_variable = (int) float_variable;";
        string Username = "";
        string PRN = "";
        public Page2(int previousscore,string Username,string PRN)
        {
            InitializeComponent();
            score = previousscore;
            this.Username = Username;
            this.PRN = PRN;
            this.WindowState = FormWindowState.Maximized;
        }
        public Page2()
        {
            InitializeComponent();
        }
  
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
            
            Page3 obj = new Page3(score,Username,PRN);
            obj.Show();
            this.Hide();
        }

        private void Page2_Load(object sender, EventArgs e)
        {

        }
    }
}
