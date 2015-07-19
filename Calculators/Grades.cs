using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

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
                else if (corte01 <= 0)
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

        private void KeyDown01(object sender, System.Windows.Forms.KeyEventArgs e)
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
                int asd1 = Int32.Parse(corte1.Text);
                if (asd1 == 0)
                {
                    int qwe1 = 0;
                    corte1.Text = qwe1 + "";
                }
                else if (asd1 > 0)
                {
                    int ert1 = asd1 - 1;
                    corte1.Text = ert1 + "";
                }
            }
        }
        private void KeyDown02(object sender, System.Windows.Forms.KeyEventArgs e)
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
                int asd2 = Int32.Parse(corte2.Text);
                if (asd2 == 0)
                {
                    int qwe2 = 0;
                    corte2.Text = qwe2 + "";
                }
                else if (asd2 > 0)
                {
                    int ert2 = asd2 - 1;
                    corte2.Text = ert2 + "";
                }
                
            }
        }
        private void KeyDown03(object sender, System.Windows.Forms.KeyEventArgs e)
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
                int asd3 = Int32.Parse(corte3.Text);
                if (asd3 == 0)
                {
                    int qwe3 = 0;
                    corte3.Text = qwe3 + "";
                }
                else if (asd3 > 0)
                {
                    int ert3 = asd3 - 1;
                    corte3.Text = ert3 + "";
                }
            }
        }
        private void KeyDown040506(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region MouseWheel Methods

        private void corte1_MouseWH(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                int asd1 = Int32.Parse(corte1.Text) + 1;
                corte1.Text = asd1 + "";
            }
            else if (e.Delta < 0)
            {
                int asd1 = Int32.Parse(corte1.Text);
                if (asd1 == 0)
                {
                    int qwe1 = 0;
                    corte1.Text = qwe1 + "";
                }
                else if (asd1 > 0)
                {
                    int ert1 = asd1 - 1;
                    corte1.Text = ert1 + "";
                }
            }
        }
        private void corte2_MouseWH(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                int asd2 = Int32.Parse(corte2.Text) + 1;
                corte2.Text = asd2 + "";
            }
            else if (e.Delta < 0)
            {
                int asd2 = Int32.Parse(corte2.Text);
                if (asd2 == 0)
                {
                    int qwe2 = 0;
                    corte2.Text = qwe2 + "";
                }
                else if (asd2 > 0)
                {
                    int ert2 = asd2 - 1;
                    corte2.Text = ert2 + "";
                }
            }
        }
        private void corte3_MouseWH(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                int asd3 = Int32.Parse(corte3.Text) + 1;
                corte3.Text = asd3 + "";
            }
            else if (e.Delta < 0)
            {
                int asd3 = Int32.Parse(corte3.Text);
                if (asd3 == 0)
                {
                    int qwe3 = 0;
                    corte3.Text = qwe3 + "";
                }
                else if (asd3 > 0)
                {
                    int ert3 = asd3 - 1;
                    corte3.Text = ert3 + "";
                }
            }
        }
        #endregion

        #region ToolTips when hovering mouse
        private void corte1_MouseHover(object sender, EventArgs e)
        {
            ToolTip TT = new ToolTip();
            TT.SetToolTip(this.corte1, "Primer corte de notas");
        }

        private void MouseWheelHandler(object sender, MouseWheelEventArgs e)
        {
        if (e.Delta > 0)
            {
                int asd1 = Int32.Parse(corte1.Text) + 1;
                corte1.Text = asd1 + "";
            }
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