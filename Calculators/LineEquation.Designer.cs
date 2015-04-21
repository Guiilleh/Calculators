namespace Calculators
{
    partial class LineEquation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineEquation));
            this.P1 = new System.Windows.Forms.Label();
            this.P1comma = new System.Windows.Forms.Label();
            this.P1parenthesis = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.P2paranthesis = new System.Windows.Forms.Label();
            this.P2comma = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.Separator1 = new System.Windows.Forms.Label();
            this.Separator2 = new System.Windows.Forms.Label();
            this.Separator4 = new System.Windows.Forms.Label();
            this.Separator3 = new System.Windows.Forms.Label();
            this.Separator5 = new System.Windows.Forms.Label();
            this.Separator6 = new System.Windows.Forms.Label();
            this.Separator7 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.Divisor = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.EQ8 = new System.Windows.Forms.Label();
            this.EQ1part1 = new System.Windows.Forms.Label();
            this.EQ3 = new System.Windows.Forms.Label();
            this.EQ4 = new System.Windows.Forms.Label();
            this.EQ5 = new System.Windows.Forms.Label();
            this.EQ6 = new System.Windows.Forms.Label();
            this.EQ7 = new System.Windows.Forms.Label();
            this.EQ9 = new System.Windows.Forms.Label();
            this.EQ1part2 = new System.Windows.Forms.Label();
            this.EQ1part3 = new System.Windows.Forms.Label();
            this.EQ1part4 = new System.Windows.Forms.Label();
            this.EQ2part3 = new System.Windows.Forms.Label();
            this.EQ2part2 = new System.Windows.Forms.Label();
            this.EQ2part1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EQ2part4 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.equal1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.Location = new System.Drawing.Point(23, 12);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(29, 15);
            this.P1.TabIndex = 32;
            this.P1.Text = "P1 (";
            // 
            // P1comma
            // 
            this.P1comma.AutoSize = true;
            this.P1comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1comma.Location = new System.Drawing.Point(76, 10);
            this.P1comma.Name = "P1comma";
            this.P1comma.Size = new System.Drawing.Size(13, 20);
            this.P1comma.TabIndex = 5;
            this.P1comma.Text = ",";
            // 
            // P1parenthesis
            // 
            this.P1parenthesis.AutoSize = true;
            this.P1parenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1parenthesis.Location = new System.Drawing.Point(111, 12);
            this.P1parenthesis.Name = "P1parenthesis";
            this.P1parenthesis.Size = new System.Drawing.Size(11, 15);
            this.P1parenthesis.TabIndex = 6;
            this.P1parenthesis.Text = ")";
            // 
            // x1
            // 
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1.Location = new System.Drawing.Point(48, 10);
            this.x1.MaxLength = 3;
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(30, 21);
            this.x1.TabIndex = 0;
            this.x1.Text = "0";
            this.x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x1.TextChanged += new System.EventHandler(this.MainMLE1_Run);
            this.x1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x1_KeyDown);
            this.x1.Leave += new System.EventHandler(this.MainMLE1_Run);
            this.x1.MouseHover += new System.EventHandler(this.x1_MouseHover);
            // 
            // y1
            // 
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y1.Location = new System.Drawing.Point(85, 10);
            this.y1.MaxLength = 3;
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(30, 21);
            this.y1.TabIndex = 1;
            this.y1.Text = "0";
            this.y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y1.TextChanged += new System.EventHandler(this.MainMLE1_Run);
            this.y1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y1_KeyDown);
            this.y1.Leave += new System.EventHandler(this.MainMLE1_Run);
            this.y1.MouseHover += new System.EventHandler(this.y1_MouseHover);
            // 
            // y2
            // 
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y2.Location = new System.Drawing.Point(209, 10);
            this.y2.MaxLength = 3;
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(30, 21);
            this.y2.TabIndex = 3;
            this.y2.Text = "0";
            this.y2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y2.TextChanged += new System.EventHandler(this.MainMLE1_Run);
            this.y2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y2_KeyDown);
            this.y2.Leave += new System.EventHandler(this.MainMLE1_Run);
            this.y2.MouseHover += new System.EventHandler(this.y2_MouseHover);
            // 
            // x2
            // 
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.Location = new System.Drawing.Point(172, 10);
            this.x2.MaxLength = 3;
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(30, 21);
            this.x2.TabIndex = 2;
            this.x2.Text = "0";
            this.x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x2.TextChanged += new System.EventHandler(this.MainMLE1_Run);
            this.x2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x2_KeyDown);
            this.x2.Leave += new System.EventHandler(this.MainMLE1_Run);
            this.x2.MouseHover += new System.EventHandler(this.x2_MouseHover);
            // 
            // P2paranthesis
            // 
            this.P2paranthesis.AutoSize = true;
            this.P2paranthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2paranthesis.Location = new System.Drawing.Point(236, 12);
            this.P2paranthesis.Name = "P2paranthesis";
            this.P2paranthesis.Size = new System.Drawing.Size(11, 15);
            this.P2paranthesis.TabIndex = 8;
            this.P2paranthesis.Text = ")";
            // 
            // P2comma
            // 
            this.P2comma.AutoSize = true;
            this.P2comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2comma.Location = new System.Drawing.Point(199, 10);
            this.P2comma.Name = "P2comma";
            this.P2comma.Size = new System.Drawing.Size(13, 20);
            this.P2comma.TabIndex = 7;
            this.P2comma.Text = ",";
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2.Location = new System.Drawing.Point(147, 12);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(29, 15);
            this.P2.TabIndex = 9;
            this.P2.Text = "P2 (";
            // 
            // Separator1
            // 
            this.Separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator1.Location = new System.Drawing.Point(10, 40);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(255, 2);
            this.Separator1.TabIndex = 40;
            this.Separator1.Text = "_";
            // 
            // Separator2
            // 
            this.Separator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator2.Location = new System.Drawing.Point(10, 100);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(255, 2);
            this.Separator2.TabIndex = 39;
            this.Separator2.Text = "_";
            // 
            // Separator4
            // 
            this.Separator4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator4.Location = new System.Drawing.Point(10, 200);
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(255, 2);
            this.Separator4.TabIndex = 67;
            this.Separator4.Text = "_";
            // 
            // Separator3
            // 
            this.Separator3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator3.Location = new System.Drawing.Point(10, 160);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(255, 2);
            this.Separator3.TabIndex = 37;
            this.Separator3.Text = "_";
            // 
            // Separator5
            // 
            this.Separator5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator5.Location = new System.Drawing.Point(10, 240);
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(255, 2);
            this.Separator5.TabIndex = 46;
            this.Separator5.Text = "_";
            // 
            // Separator6
            // 
            this.Separator6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator6.Location = new System.Drawing.Point(10, 280);
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(255, 2);
            this.Separator6.TabIndex = 45;
            this.Separator6.Text = "_";
            // 
            // Separator7
            // 
            this.Separator7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator7.Location = new System.Drawing.Point(10, 380);
            this.Separator7.Name = "Separator7";
            this.Separator7.Size = new System.Drawing.Size(255, 2);
            this.Separator7.TabIndex = 44;
            this.Separator7.Text = "_";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(75, 288);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(104, 17);
            this.label31.TabIndex = 36;
            this.label31.Text = "Divide todo por";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Divisor
            // 
            this.Divisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisor.Location = new System.Drawing.Point(179, 286);
            this.Divisor.Name = "Divisor";
            this.Divisor.Size = new System.Drawing.Size(20, 23);
            this.Divisor.TabIndex = 4;
            this.Divisor.Text = "1";
            this.Divisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Divisor.TextChanged += new System.EventHandler(this.MainMLE1_Run);
            this.Divisor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Divisor_KeyDown);
            this.Divisor.Leave += new System.EventHandler(this.MainMLE1_Run);
            this.Divisor.MouseHover += new System.EventHandler(this.Divisor_MouseHover);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(59, 215);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(19, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "→";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(59, 255);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(19, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "→";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(59, 318);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 13);
            this.label34.TabIndex = 8;
            this.label34.Text = "→";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(59, 352);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(19, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "→";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(55, 389);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(164, 17);
            this.label38.TabIndex = 37;
            this.label38.Text = "Multiplicando todo por -1";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EQ8
            // 
            this.EQ8.AutoSize = true;
            this.EQ8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ8.Location = new System.Drawing.Point(94, 421);
            this.EQ8.Name = "EQ8";
            this.EQ8.Size = new System.Drawing.Size(57, 15);
            this.EQ8.TabIndex = 91;
            this.EQ8.Text = "X+Y+1=0";
            // 
            // EQ1part1
            // 
            this.EQ1part1.AutoSize = true;
            this.EQ1part1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ1part1.Location = new System.Drawing.Point(60, 61);
            this.EQ1part1.Name = "EQ1part1";
            this.EQ1part1.Size = new System.Drawing.Size(28, 15);
            this.EQ1part1.TabIndex = 92;
            this.EQ1part1.Text = "Y+1";
            // 
            // EQ3
            // 
            this.EQ3.AutoSize = true;
            this.EQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ3.Location = new System.Drawing.Point(94, 172);
            this.EQ3.Name = "EQ3";
            this.EQ3.Size = new System.Drawing.Size(57, 15);
            this.EQ3.TabIndex = 94;
            this.EQ3.Text = "X+Y+1=0";
            // 
            // EQ4
            // 
            this.EQ4.AutoSize = true;
            this.EQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ4.Location = new System.Drawing.Point(94, 215);
            this.EQ4.Name = "EQ4";
            this.EQ4.Size = new System.Drawing.Size(57, 15);
            this.EQ4.TabIndex = 95;
            this.EQ4.Text = "X+Y+1=0";
            // 
            // EQ5
            // 
            this.EQ5.AutoSize = true;
            this.EQ5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ5.Location = new System.Drawing.Point(94, 255);
            this.EQ5.Name = "EQ5";
            this.EQ5.Size = new System.Drawing.Size(57, 15);
            this.EQ5.TabIndex = 96;
            this.EQ5.Text = "X+Y+1=0";
            // 
            // EQ6
            // 
            this.EQ6.AutoSize = true;
            this.EQ6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ6.Location = new System.Drawing.Point(94, 318);
            this.EQ6.Name = "EQ6";
            this.EQ6.Size = new System.Drawing.Size(57, 15);
            this.EQ6.TabIndex = 97;
            this.EQ6.Text = "X+Y+1=0";
            // 
            // EQ7
            // 
            this.EQ7.AutoSize = true;
            this.EQ7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ7.Location = new System.Drawing.Point(94, 352);
            this.EQ7.Name = "EQ7";
            this.EQ7.Size = new System.Drawing.Size(57, 15);
            this.EQ7.TabIndex = 98;
            this.EQ7.Text = "X+Y+1=0";
            // 
            // EQ9
            // 
            this.EQ9.AutoSize = true;
            this.EQ9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ9.Location = new System.Drawing.Point(94, 458);
            this.EQ9.Name = "EQ9";
            this.EQ9.Size = new System.Drawing.Size(57, 15);
            this.EQ9.TabIndex = 99;
            this.EQ9.Text = "X+Y+1=0";
            // 
            // EQ1part2
            // 
            this.EQ1part2.AutoSize = true;
            this.EQ1part2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ1part2.Location = new System.Drawing.Point(120, 52);
            this.EQ1part2.Name = "EQ1part2";
            this.EQ1part2.Size = new System.Drawing.Size(28, 15);
            this.EQ1part2.TabIndex = 100;
            this.EQ1part2.Text = "1+1";
            // 
            // EQ1part3
            // 
            this.EQ1part3.AutoSize = true;
            this.EQ1part3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ1part3.Location = new System.Drawing.Point(120, 72);
            this.EQ1part3.Name = "EQ1part3";
            this.EQ1part3.Size = new System.Drawing.Size(28, 15);
            this.EQ1part3.TabIndex = 101;
            this.EQ1part3.Text = "1+1";
            // 
            // EQ1part4
            // 
            this.EQ1part4.AutoSize = true;
            this.EQ1part4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ1part4.Location = new System.Drawing.Point(178, 61);
            this.EQ1part4.Name = "EQ1part4";
            this.EQ1part4.Size = new System.Drawing.Size(37, 15);
            this.EQ1part4.TabIndex = 102;
            this.EQ1part4.Text = "(X+1)";
            // 
            // EQ2part3
            // 
            this.EQ2part3.AutoSize = true;
            this.EQ2part3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ2part3.Location = new System.Drawing.Point(134, 132);
            this.EQ2part3.Name = "EQ2part3";
            this.EQ2part3.Size = new System.Drawing.Size(14, 15);
            this.EQ2part3.TabIndex = 105;
            this.EQ2part3.Text = "1";
            // 
            // EQ2part2
            // 
            this.EQ2part2.AutoSize = true;
            this.EQ2part2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ2part2.Location = new System.Drawing.Point(134, 112);
            this.EQ2part2.Name = "EQ2part2";
            this.EQ2part2.Size = new System.Drawing.Size(14, 15);
            this.EQ2part2.TabIndex = 104;
            this.EQ2part2.Text = "1";
            // 
            // EQ2part1
            // 
            this.EQ2part1.AutoSize = true;
            this.EQ2part1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ2part1.Location = new System.Drawing.Point(68, 121);
            this.EQ2part1.Name = "EQ2part1";
            this.EQ2part1.Size = new System.Drawing.Size(28, 15);
            this.EQ2part1.TabIndex = 103;
            this.EQ2part1.Text = "Y+1";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(128, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 2);
            this.label9.TabIndex = 114;
            this.label9.Text = "label1";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(161, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 44);
            this.label10.TabIndex = 113;
            this.label10.Text = ")";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(110, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 44);
            this.label11.TabIndex = 112;
            this.label11.Text = "(";
            // 
            // EQ2part4
            // 
            this.EQ2part4.AutoSize = true;
            this.EQ2part4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQ2part4.Location = new System.Drawing.Point(169, 121);
            this.EQ2part4.Name = "EQ2part4";
            this.EQ2part4.Size = new System.Drawing.Size(37, 15);
            this.EQ2part4.TabIndex = 106;
            this.EQ2part4.Text = "(X+1)";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(59, 421);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(19, 13);
            this.label36.TabIndex = 18;
            this.label36.Text = "→";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(59, 458);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(19, 13);
            this.label37.TabIndex = 19;
            this.label37.Text = "→";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 44);
            this.label5.TabIndex = 109;
            this.label5.Text = "(";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 44);
            this.label7.TabIndex = 110;
            this.label7.Text = ")";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(120, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 2);
            this.label1.TabIndex = 115;
            this.label1.Text = "label1";
            // 
            // equal1
            // 
            this.equal1.AutoSize = true;
            this.equal1.Location = new System.Drawing.Point(97, 63);
            this.equal1.Name = "equal1";
            this.equal1.Size = new System.Drawing.Size(13, 13);
            this.equal1.TabIndex = 120;
            this.equal1.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "=";
            // 
            // LineEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(274, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EQ2part4);
            this.Controls.Add(this.EQ2part3);
            this.Controls.Add(this.EQ2part2);
            this.Controls.Add(this.EQ2part1);
            this.Controls.Add(this.EQ1part4);
            this.Controls.Add(this.EQ1part3);
            this.Controls.Add(this.EQ1part2);
            this.Controls.Add(this.EQ9);
            this.Controls.Add(this.EQ7);
            this.Controls.Add(this.EQ6);
            this.Controls.Add(this.EQ5);
            this.Controls.Add(this.EQ4);
            this.Controls.Add(this.EQ3);
            this.Controls.Add(this.EQ1part1);
            this.Controls.Add(this.EQ8);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.Divisor);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.Separator7);
            this.Controls.Add(this.Separator6);
            this.Controls.Add(this.Separator5);
            this.Controls.Add(this.Separator3);
            this.Controls.Add(this.Separator4);
            this.Controls.Add(this.Separator2);
            this.Controls.Add(this.Separator1);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.P2paranthesis);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.P1parenthesis);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.equal1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.P1comma);
            this.Controls.Add(this.P2comma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LineEquation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecuación de la Recta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P1comma;
        private System.Windows.Forms.Label P1parenthesis;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Label P2paranthesis;
        private System.Windows.Forms.Label P2comma;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label Separator1;
        private System.Windows.Forms.Label Separator2;
        private System.Windows.Forms.Label Separator4;
        private System.Windows.Forms.Label Separator3;
        private System.Windows.Forms.Label Separator5;
        private System.Windows.Forms.Label Separator6;
        private System.Windows.Forms.Label Separator7;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox Divisor;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label EQ8;
        private System.Windows.Forms.Label EQ1part1;
        private System.Windows.Forms.Label EQ3;
        private System.Windows.Forms.Label EQ4;
        private System.Windows.Forms.Label EQ5;
        private System.Windows.Forms.Label EQ6;
        private System.Windows.Forms.Label EQ7;
        private System.Windows.Forms.Label EQ9;
        private System.Windows.Forms.Label EQ1part2;
        private System.Windows.Forms.Label EQ1part3;
        private System.Windows.Forms.Label EQ1part4;
        private System.Windows.Forms.Label EQ2part3;
        private System.Windows.Forms.Label EQ2part2;
        private System.Windows.Forms.Label EQ2part1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label EQ2part4;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label equal1;
        private System.Windows.Forms.Label label4;
    }
}