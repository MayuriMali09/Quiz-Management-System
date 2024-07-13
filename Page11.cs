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
    public partial class Page6 : Form
    {
        int score = 0;
        string Username = "";
        string PRN = "";
        public Page11(int previousscore, string Username, string PRN)
        {
            InitializeComponent();
            score = previousscore;
            this.Username = Username;
            this.PRN = PRN;
            this.WindowState = FormWindowState.Maximized;
        }
        public Page6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Your score is " + score.ToString();
            if (score < 3)
            {
                label2.Text = "Click to try another attempt";
            }
            else
            {
                label2.Text = "Congratulations!!! ,You have successfully passed test....";
            }
            Class1 obj = new Class1();
            int no=obj.add_data(Username, PRN, score);
            if (no > 0)
            {
                MessageBox.Show("Data added successfully");
            }
            else
            {
                MessageBox.Show("Data not added");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Page1 obj = new Page1(Username, PRN);
            obj.Show();
        }
    }
}
