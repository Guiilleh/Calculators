using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Buttons' Methods n' Actions
        public void BGrades_Click(object sender, EventArgs e)
        {
            this.Opacity = .7;
            Grades asd1 = new Grades();
            asd1.ShowDialog();
            this.Opacity = 100;
        }
        private void BEquation_Click(object sender, EventArgs e)
        {
            this.Opacity = .7;
            LineEquation asd2 = new LineEquation();
            asd2.ShowDialog();
            this.Opacity = 100;
        }
        private void Test1_Click(object sender, EventArgs e)
        {
            test1.Visible = false;
            this.Opacity = .7;
            Test asd3 = new Test();
            asd3.ShowDialog();
            this.Opacity = 100;
        }
        #endregion

        #region ESC to close method
        private void ESCClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region Label1 Shit
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1b.Enabled = true;
        }
        private void timer1b_Tick(object sender, EventArgs e)
        {
            if (label1.ForeColor.R > 10)
            {
                int apparitionSpeed = 10;
                label1.ForeColor = Color.FromArgb(
                    label1.ForeColor.R - apparitionSpeed,
                    label1.ForeColor.G - apparitionSpeed,
                    label1.ForeColor.B - apparitionSpeed);

                if (label1.ForeColor.R == 10)
                {
                    timer1.Stop();
                    timer1b.Stop();
                    timer2.Stop();
                    timer1.Enabled = false;
                    timer1b.Enabled = false;
                    timer2.Enabled = false;
                }
            }
            else
            {
                return;
            }
        }
        private void Buttons_MouseHover(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.ForeColor.R < 240)
            {
                int fadingSpeed = 10;
                label1.ForeColor = Color.FromArgb(
                    label1.ForeColor.R + fadingSpeed,
                    label1.ForeColor.G + fadingSpeed,
                    label1.ForeColor.B + fadingSpeed);

                if (label1.ForeColor.R >= this.BackColor.R)
                {
                    timer1.Stop();
                    label1.ForeColor = this.BackColor;
                    timer1b.Stop();
                    timer2.Stop();
                    timer1.Enabled = false;
                    timer1b.Enabled = false;
                    timer2.Enabled = false;
                }
            }
            else
            {
                return;
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (test1.Visible == true)
            {
                test1.Visible = false;
            }
            else if (test1.Visible == false)
            {
                test1.Visible = true;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }
        #endregion
        
    }
}