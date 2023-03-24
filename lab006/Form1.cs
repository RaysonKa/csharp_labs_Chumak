using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            firstNum.Text = "";
            secNum.Text = "";
            sumNum.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sumNum.Enabled = false;
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plusBut_Click(object sender, EventArgs e)
        {
            int maxLen = 1 + Math.Max(firstNum.Text.Length, secNum.Text.Length);
            int[] num1 = new int[maxLen];
            int[] num2 = new int[maxLen];
            int[] sum = new int[maxLen];
            int[] extra = new int[maxLen];
            int numId, textId;
            numId = maxLen - 1;
            textId = firstNum.Text.Length - 1;
            while (textId >= 1)
            {
                num1[numId] = (firstNum.Text[textId] - '0');
                textId--;
                numId--;

            }
            for (numId = maxLen - 1; numId > 0; numId--)
            {
                sum[numId] = (num1[numId] + num2[numId] + extra[numId]) % 10;
                extra[numId - 1] = (num1[numId] + num2[numId] + extra[numId]) % 10;
            }
            sum[0] = extra[0];
            bool isNumber = false;
            foreach (int digit in sum)
            {
                if (digit > 0)
                {
                    isNumber = true;
                    sumNum.Text += digit;

                }
                else
                {
                    if (isNumber)
                        sumNum.Text += digit;
                }
            }
        }

        
    }
}
