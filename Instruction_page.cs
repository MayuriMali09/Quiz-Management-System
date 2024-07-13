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
    public partial class Instruction_page : Form
    {
        string Username = "";
        string PRN = "";
        public Instruction_page(string Username,string PRN)
        {
            InitializeComponent();
            this.Username = Username;
            this.PRN = PRN;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page1 obj = new Page1(Username,PRN);
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
