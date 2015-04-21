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
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }

        #region Main Method Grades Calculator 1
        public void MainMGC1()
        {
            try
            {
                Double corte01 = Double.Parse(corte1.Text);
                Double corte02 = Double.Parse(corte2.Text);
                Double corte03 = Double.Parse(corte3.Text);

                if (corte01 > 20)
                {
                    corte1.Text = "20";
                }
                else if (corte01 < 0)
                {
                    corte1.Text = "0";
                }
                else 
                {
                    corte1.Text = corte1.Text;
                }

                if (corte02 > 20)
                {
                    corte2.Text = "20";
                }
                else if (corte02 < 0)
                {
                    corte2.Text = "0";
                }
                else
                {
                    corte2.Text = corte2.Text;
                }

                if (corte03 > 20)
                {
                    corte3.Text = "20";
                }
                else if (corte03 < 0)
                {
                    corte3.Text = "0";
                }
                else
                {
                    corte3.Text = corte3.Text;
                }

                Double result = (corte01 > 20 ? 20 : corte01) * 0.3 + (corte02 > 20 ? 20 : corte02) * 0.3 + (corte03 > 20 ? 20 : corte03) * 0.4;
                Double result01 = result;
                Double result02 = result;

                String resultA = result01.ToString("0.##");
                String resultB = result02.ToString("0");

                result1.Text = resultA;
                result2.Text = resultB;
            }
            catch
            {
                MessageBox.Show("Sólo números",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }//MainMethodGC1(); END
        #endregion
        
        #region KeyDown Methods
        private void KeyDown01(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Up)
            {
                int asd1 = Int32.Parse(corte1.Text) + 1;
                corte1.Text = asd1 + "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                int asd1 = Int32.Parse(corte1.Text) - 1;
                corte1.Text = asd1 + "";
            }
        }
        private void KeyDown02(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Up)
            {
                int asd2 = Int32.Parse(corte2.Text) + 1;
                corte2.Text = asd2 + "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                int asd2 = Int32.Parse(corte2.Text) - 1;
                corte2.Text = asd2 + "";
            }
        }
        private void KeyDown03(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Up)
            {
                int asd3 = Int32.Parse(corte3.Text) + 1;
                corte3.Text = asd3 + "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                int asd3 = Int32.Parse(corte3.Text) - 1;
                corte3.Text = asd3 + "";
            }
        }
        private void KeyDown040506(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region ToolTips when hovering mouse
        private void corte1_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.corte1, "Primer corte de notas");
        }
        private void corte2_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.corte2, "Segundo corte de notas");
        }
        private void corte3_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.corte3, "Tercer corte de notas");
        }
        private void result1_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.result1, "Nota definitiva exacta");
        }
        private void result2_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.result2, "Nota definitiva redondeada \nSin decimales");
        }
        #endregion

        #region Methods_Run
        private void MainMGC1_Run(object sender, EventArgs e)
        {
            MainMGC1();
        }
        #endregion
    }
}