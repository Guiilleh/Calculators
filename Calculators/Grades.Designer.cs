namespace Calculators
{
    partial class Grades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grades));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelresult = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.corte1 = new System.Windows.Forms.TextBox();
            this.corte2 = new System.Windows.Forms.TextBox();
            this.corte3 = new System.Windows.Forms.TextBox();
            this.result1 = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1er Corte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2do Corte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3er Corte";
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Location = new System.Drawing.Point(273, 23);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(51, 13);
            this.labelresult.TabIndex = 3;
            this.labelresult.Text = "Definitiva";
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(300, 47);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(13, 13);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            // 
            // corte1
            // 
            this.corte1.BackColor = System.Drawing.SystemColors.Window;
            this.corte1.Location = new System.Drawing.Point(37, 47);
            this.corte1.MaxLength = 3;
            this.corte1.Name = "corte1";
            this.corte1.Size = new System.Drawing.Size(46, 20);
            this.corte1.TabIndex = 5;
            this.corte1.Text = "0";
            this.corte1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.corte1.TextChanged += new System.EventHandler(this.MainMGC1_Run);
            this.corte1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown01);
            this.corte1.Leave += new System.EventHandler(this.MainMGC1_Run);
            this.corte1.MouseHover += new System.EventHandler(this.corte1_MouseHover);
            // 
            // corte2
            // 
            this.corte2.BackColor = System.Drawing.SystemColors.Window;
            this.corte2.Location = new System.Drawing.Point(102, 47);
            this.corte2.MaxLength = 3;
            this.corte2.Name = "corte2";
            this.corte2.Size = new System.Drawing.Size(46, 20);
            this.corte2.TabIndex = 6;
            this.corte2.Text = "0";
            this.corte2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.corte2.TextChanged += new System.EventHandler(this.MainMGC1_Run);
            this.corte2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown02);
            this.corte2.Leave += new System.EventHandler(this.MainMGC1_Run);
            this.corte2.MouseHover += new System.EventHandler(this.corte2_MouseHover);
            // 
            // corte3
            // 
            this.corte3.BackColor = System.Drawing.SystemColors.Window;
            this.corte3.Location = new System.Drawing.Point(163, 47);
            this.corte3.MaxLength = 3;
            this.corte3.Name = "corte3";
            this.corte3.Size = new System.Drawing.Size(46, 20);
            this.corte3.TabIndex = 7;
            this.corte3.Text = "0";
            this.corte3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.corte3.TextChanged += new System.EventHandler(this.MainMGC1_Run);
            this.corte3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown03);
            this.corte3.Leave += new System.EventHandler(this.MainMGC1_Run);
            this.corte3.MouseHover += new System.EventHandler(this.corte3_MouseHover);
            // 
            // result1
            // 
            this.result1.BackColor = System.Drawing.SystemColors.Window;
            this.result1.Location = new System.Drawing.Point(246, 47);
            this.result1.MaxLength = 6;
            this.result1.Name = "result1";
            this.result1.ReadOnly = true;
            this.result1.Size = new System.Drawing.Size(46, 20);
            this.result1.TabIndex = 8;
            this.result1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown040506);
            this.result1.MouseHover += new System.EventHandler(this.result1_MouseHover);
            // 
            // result2
            // 
            this.result2.BackColor = System.Drawing.SystemColors.Window;
            this.result2.Location = new System.Drawing.Point(319, 47);
            this.result2.MaxLength = 2;
            this.result2.Name = "result2";
            this.result2.ReadOnly = true;
            this.result2.Size = new System.Drawing.Size(31, 20);
            this.result2.TabIndex = 9;
            this.result2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown040506);
            this.result2.MouseHover += new System.EventHandler(this.result2_MouseHover);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(220, 85);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 38);
            this.calcular.TabIndex = 10;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.MainMGC1_Run);
            this.calcular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown040506);
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 142);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.corte3);
            this.Controls.Add(this.corte2);
            this.Controls.Add(this.corte1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Grades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.TextBox corte1;
        private System.Windows.Forms.TextBox corte3;
        private System.Windows.Forms.TextBox corte2;
        private System.Windows.Forms.TextBox result1;
        private System.Windows.Forms.TextBox result2;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}