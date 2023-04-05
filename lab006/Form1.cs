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
            int maxLen = 1 + Math.Max(firstNum.Text.Length, secNum.TextLength);
            int[] num1 = new int[maxLen];

            int[] num2 = new int[maxLen];
            int[] sum = new int[maxLen];
            int[] extra = new int[maxLen];

            int numberIdx, textIdx;

            numberIdx = maxLen - 1;
            textIdx = firstNum.Text.Length - 1;

            while (textIdx >= 0)
            {
                num1[numberIdx] = (firstNum.Text[textIdx] - '0');
                textIdx--;
                numberIdx--;
            }
            numberIdx = maxLen - 1;
            textIdx = secNum.TextLength - 1;
            while (textIdx >= 0)
            {
                num2[numberIdx] = (secNum.Text[textIdx] - '0');
                textIdx--;
                numberIdx--;
            }
            for (numberIdx = maxLen - 1; numberIdx > 0; numberIdx--)
            {
                sum[numberIdx] = (num1[numberIdx] + num2[numberIdx] + extra[numberIdx]) % 10;
                extra[numberIdx - 1] = (num1[numberIdx] + num2[numberIdx] + extra[numberIdx]) / 10;
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
