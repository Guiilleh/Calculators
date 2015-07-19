namespace Calculators
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BGrades = new System.Windows.Forms.Button();
            this.BEquation = new System.Windows.Forms.Button();
            this.test1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hecho por Guillermo Fernández";
            this.label1.Visible = false;
            // 
            // BGrades
            // 
            this.BGrades.Location = new System.Drawing.Point(23, 40);
            this.BGrades.Name = "BGrades";
            this.BGrades.Size = new System.Drawing.Size(150, 40);
            this.BGrades.TabIndex = 0;
            this.BGrades.Text = "Calculador de Notas";
            this.BGrades.UseVisualStyleBackColor = true;
            this.BGrades.Click += new System.EventHandler(this.BGrades_Click);
            this.BGrades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            this.BGrades.MouseLeave += new System.EventHandler(this.ObjectMouseHover_OUT);
            this.BGrades.MouseHover += new System.EventHandler(this.ObjectMouseHover_IN);
            // 
            // BEquation
            // 
            this.BEquation.Location = new System.Drawing.Point(206, 40);
            this.BEquation.Name = "BEquation";
            this.BEquation.Size = new System.Drawing.Size(150, 40);
            this.BEquation.TabIndex = 1;
            this.BEquation.Text = "Ecuación de la Recta";
            this.BEquation.UseVisualStyleBackColor = true;
            this.BEquation.Click += new System.EventHandler(this.BEquation_Click);
            this.BEquation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            this.BEquation.MouseLeave += new System.EventHandler(this.ObjectMouseHover_OUT);
            this.BEquation.MouseHover += new System.EventHandler(this.ObjectMouseHover_IN);
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(63, 105);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(75, 23);
            this.test1.TabIndex = 3;
            this.test1.Text = "Testing1";
            this.test1.UseVisualStyleBackColor = true;
            this.test1.Click += new System.EventHandler(this.test1_Click);
            this.test1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            this.test1.MouseLeave += new System.EventHandler(this.ObjectMouseHover_OUT);
            this.test1.MouseHover += new System.EventHandler(this.ObjectMouseHover_IN);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(384, 142);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.BEquation);
            this.Controls.Add(this.BGrades);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculators";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ESCClose_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BGrades;
        private System.Windows.Forms.Button BEquation;
        private System.Windows.Forms.Button test1;
    }
}