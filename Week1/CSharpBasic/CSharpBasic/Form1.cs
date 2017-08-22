using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "bool";
            textBox2.Text = sizeof(bool).ToString();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "char";
            textBox2.Text = sizeof(char).ToString();
            textBox3.Text = (char.MinValue - '\0' ).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "unsigned int 16 bit";
            textBox2.Text = sizeof(UInt16).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Sbyte";
            textBox2.Text = sizeof(SByte).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Long";
            textBox2.Text = sizeof(long).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "float";
            textBox2.Text = sizeof(float).ToString();
            textBox3.Text = float.MinValue.ToString();
            textBox4.Text = float.MaxValue.ToString();

        }
    }
}
