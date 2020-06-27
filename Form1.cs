using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatAge_HumAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Code
        char[] CatMonth = new char[] { '1', '2', '3' };
        char[] CatAge = new char[] { '1', '2', '3' };

        string[] HumMonth = new string[] { "1.4", "2.6", "3.9" };
        string[] HumAge = new string[] { "15", "24", "28" };
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string output = "";
            int index;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(CatAge, c);
                    output += HumAge[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBox2.Text = output + " лет";
        }
        #region TextBox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #region 1
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox3.Text;
            string output = "";
            int index;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(CatMonth, c);
                    output += HumMonth[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBox4.Text = output + " лет";
        }
        #region 2
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
