using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string s="";
            s= textBox1.Text;
            if (string.IsNullOrEmpty(s))
                richTextBox1.AppendText("Nothing here\n");
            else
                richTextBox1.AppendText("Element 1:" + s + "\n");

            s = textBox2.Text;
            if (string.IsNullOrEmpty(s))
                richTextBox1.AppendText("Nothing here\n");
            else
                richTextBox1.AppendText("Element 2:" + s + "\n");
            s = textBox3.Text;
            if (string.IsNullOrEmpty(s))
                richTextBox1.AppendText("Nothing here\n");
            else
                richTextBox1.AppendText("Element 3:" + s + "\n");
            s = textBox4.Text;
            if (string.IsNullOrEmpty(s))
                richTextBox1.AppendText("Nothing here\n");
            else
                richTextBox1.AppendText("Element 4:" + s + "\n");
            s = textBox5.Text;
            if (string.IsNullOrEmpty(s))
                richTextBox1.AppendText("Nothing here\n");
            else
                richTextBox1.AppendText("Element 5:" + s + "\n");
        }
    }
}
