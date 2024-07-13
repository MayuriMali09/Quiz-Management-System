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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string PRN = textBox2.Text;
            Instruction_page obj = new Instruction_page(Username,PRN);
            if (textBox3.Text == "Rit123" && textBox2.Text.All(char.IsLetter) && textBox1.Text.All(char.IsDigit))
            {
                obj.Show();
                this.Hide();
            }
            else
            {
                label4.Text = "Invalid Data provided";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            // Check if input contains only numeric characters
            bool isValid = input.All(char.IsDigit);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only numeric characters for the age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            // Check if input contains only alphabetic characters
            bool isValid = input.All(char.IsLetter);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only alphabetic characters for the name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
