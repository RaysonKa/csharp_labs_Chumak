namespace lab006
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNum = new System.Windows.Forms.TextBox();
            this.secNum = new System.Windows.Forms.TextBox();
            this.sumNum = new System.Windows.Forms.TextBox();
            this.clearBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.plusBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(335, 85);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(269, 20);
            this.firstNum.TabIndex = 0;
            // 
            // secNum
            // 
            this.secNum.Location = new System.Drawing.Point(335, 131);
            this.secNum.Name = "secNum";
            this.secNum.Size = new System.Drawing.Size(269, 20);
            this.secNum.TabIndex = 1;
            // 
            // sumNum
            // 
            this.sumNum.Location = new System.Drawing.Point(335, 231);
            this.sumNum.Name = "sumNum";
            this.sumNum.Size = new System.Drawing.Size(269, 20);
            this.sumNum.TabIndex = 2;
            // 
            // clearBut
            // 
            this.clearBut.Location = new System.Drawing.Point(335, 290);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(96, 23);
            this.clearBut.TabIndex = 3;
            this.clearBut.Text = "Clear";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.Location = new System.Drawing.Point(505, 290);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(99, 23);
            this.exitBut.TabIndex = 4;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = true;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // plusBut
            // 
            this.plusBut.Location = new System.Drawing.Point(432, 179);
            this.plusBut.Name = "plusBut";
            this.plusBut.Size = new System.Drawing.Size(75, 23);
            this.plusBut.TabIndex = 5;
            this.plusBut.Text = "+";
            this.plusBut.UseVisualStyleBackColor = true;
            this.plusBut.Click += new System.EventHandler(this.plusBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plusBut);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.clearBut);
            this.Controls.Add(this.sumNum);
            this.Controls.Add(this.secNum);
            this.Controls.Add(this.firstNum);
            this.Name = "Form1";
            this.Text = "Lab06 Dovga suma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox secNum;
        private System.Windows.Forms.TextBox sumNum;
        private System.Windows.Forms.Button clearBut;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.Button plusBut;
    }
}

