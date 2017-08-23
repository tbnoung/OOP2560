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
            textType.Text = "bool";
            textSize.Text = sizeof(bool).ToString();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textType.Text = "char";
            textSize.Text = sizeof(char).ToString();
            textMinimum.Text = (char.MinValue - '\0' ).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textType.Text = "unsigned int 16 bit";
            textSize.Text = sizeof(UInt16).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textType.Text = "Sbyte";
            textSize.Text = sizeof(SByte).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textType.Text = "Long";
            textSize.Text = sizeof(long).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textType.Text = "float";
            textSize.Text = sizeof(float).ToString();
            textMinimum.Text = float.MinValue.ToString();
            textMaximum.Text = float.MaxValue.ToString();

        }
    }
}
