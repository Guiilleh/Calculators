namespace Calculators
{
    partial class Test
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
            this.number2 = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.Label();
            this.number3 = new System.Windows.Forms.TextBox();
            this.result3 = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.TextBox();
            this.okay1 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.multest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(45, 76);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(56, 20);
            this.number2.TabIndex = 9;
            this.number2.Text = "0";
            this.number2.TextChanged += new System.EventHandler(this.MainMTest2_Run);
            this.number2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Location = new System.Drawing.Point(197, 79);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(13, 13);
            this.result2.TabIndex = 8;
            this.result2.Text = "0";
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(45, 102);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(56, 20);
            this.number3.TabIndex = 11;
            this.number3.Text = "0";
            this.number3.TextChanged += new System.EventHandler(this.MainMTest2_Run);
            this.number3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            // 
            // result3
            // 
            this.result3.AutoSize = true;
            this.result3.Location = new System.Drawing.Point(197, 105);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(13, 13);
            this.result3.TabIndex = 10;
            this.result3.Text = "0";
            // 
            // ok1
            // 
            this.ok1.Location = new System.Drawing.Point(45, 12);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(56, 20);
            this.ok1.TabIndex = 0;
            this.ok1.Text = "0";
            this.ok1.TextChanged += new System.EventHandler(this.MainMTest1_Run);
            this.ok1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            this.ok1.Leave += new System.EventHandler(this.MainMTest1_Run);
            // 
            // okay1
            // 
            this.okay1.AutoSize = true;
            this.okay1.Location = new System.Drawing.Point(107, 15);
            this.okay1.Name = "okay1";
            this.okay1.Size = new System.Drawing.Size(132, 13);
            this.okay1.TabIndex = 13;
            this.okay1.Text = "Minus Sign Detection Test";
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Location = new System.Drawing.Point(197, 53);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(13, 13);
            this.result1.TabIndex = 3;
            this.result1.Text = "0";
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(45, 50);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(56, 20);
            this.number1.TabIndex = 4;
            this.number1.Text = "0";
            this.number1.TextChanged += new System.EventHandler(this.MainMTest2_Run);
            this.number1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "0";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "±";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "0";
            // 
            // multest
            // 
            this.multest.Location = new System.Drawing.Point(45, 202);
            this.multest.Name = "multest";
            this.multest.Size = new System.Drawing.Size(56, 20);
            this.multest.TabIndex = 15;
            this.multest.Text = "8";
            this.multest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.multest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-18, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 108);
            this.label1.TabIndex = 19;
            this.label1.Text = "ZOMG";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.multest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.okay1);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.label1);
            this.Name = "Test";
            this.Text = "plusTest";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox ok1;
        private System.Windows.Forms.Label okay1;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.TextBox number3;
        private System.Windows.Forms.Label result3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox multest;
        private System.Windows.Forms.Label label1;
    }
}