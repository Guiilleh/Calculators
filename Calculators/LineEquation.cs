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
    public partial class LineEquation : Form
    {
        int Bulbasaur, Charmander, Squirtle, Pikachu = 0;
        //int a1, a2, a3, a4 = 0;
        public LineEquation()
        {
            InitializeComponent();
        }

        public void MainMethodFirstPart()
        {
            //1
            if (Bulbasaur == 0 || (Int32.Parse(x1.Text) != Bulbasaur))
            {
                Bulbasaur = Int32.Parse(x1.Text);
            }
            if (Charmander == 0 || (Int32.Parse(y1.Text) != Charmander))
            {
                Charmander = Int32.Parse(y1.Text);
            }
            if (Squirtle == 0 || (Int32.Parse(x2.Text) != Squirtle))
            {
                Squirtle = Int32.Parse(x2.Text);
            }
            if (Pikachu == 0 || (Int32.Parse(y2.Text) != Pikachu))
            {
                Pikachu = Int32.Parse(y2.Text);
            }
            int x0001v2 = Bulbasaur; // Valor de X1
            int x0001 = Bulbasaur * -1; // * -1
            int y0001v2 = Charmander; // Valor de Y1
            int y0001 = Charmander * -1; // * -1
            int x0002 = Squirtle; // Valor de X2
            int y0002 = Pikachu; // Valor de Y2
            //1 Strings EQ1
            String xa1s = x0001.ToString("+ #;- #;0");
            String ya1s = y0001.ToString("+ #;- #;0");
            String xa2s = x0002 + "";
            String ya2s = y0002 + "";
            String y01s = y0001.ToString("+ #;- #;0");
            String x01s = x0001.ToString("+ #;- #;0");

            //2
            int x2x10 = x0002 - x0001v2;
            int y2y10 = y0002 - y0001v2;
            //2 Strings EQ2
            String x2x1as = x2x10 + "";
            String y2y1as = y2y10 + "";
            String y02s = y0001.ToString("+ #;- #;0");
            String x02s = x0001.ToString("+ #;- #;0");

            //3
            int x2x1c = y0001 * x2x10;
            int y2y1c = x0001 * y2y10;
            //3 Strings EQ3
            String yi3s = x2x10.ToString("#;- #;0") + "Y";
            String xi3s = y2y10 + "X";
            String y03x2x1s = x2x1c.ToString("+ #;- #;0");
            String x03y2y1s = y2y1c.ToString("+ #;- #;0");

            //4
            int x03 = y2y10 * -1;
            int y03 = x2x10;
            int indepA = x2x1c - y2y1c;
            //4 Strings EQ4
            String xi4s = x03.ToString("#;- #;0") + "X";
            String yi4s = y03.ToString("+ #;- #;0") + "Y";
            String x03y03s = indepA.ToString("+ #;- #;0");

            //5
            int indepB = indepA * -1;
            //5 Strings EQ5
            String xi5s = x03.ToString("#;- #;0") + "X";
            String yi5s = y03.ToString("+ #;- #;0") + "Y";
            String InverseSignx03y03s = indepB + "";
        }

        public void DivIsEmptyEquals1() //Focus Leave if Div is blank, Div is 1
        {
            int x0001v2 = Bulbasaur; // Valor de X1
            int y0001v2 = Charmander; // Valor de Y1
            int x0002 = Squirtle; // Valor de X2
            int y0002 = Pikachu; // Valor de Y2
            int x0001 = Bulbasaur * -1; // * -1
            int y0001 = Charmander * -1; // * -1
            int x2x10 = x0002 - x0001v2;
            int y2y10 = y0002 - y0001v2;
            int x2x1c = y0001 * x2x10;
            int y2y1c = x0001 * y2y10;
            int indepA = x2x1c - y2y1c;
            int indepB = indepA * -1;
            int x03 = y2y10 * -1;
            int y03 = x2x10;
            String xa1s = x0001.ToString("+ #;- #;0");
            String ya1s = y0001.ToString("+ #;- #;0");
            String xa2s = x0002 + "";
            String ya2s = y0002 + "";
            String y01s = y0001.ToString("+ #;- #;0");
            String x01s = x0001.ToString("+ #;- #;0");
            String x2x1as = x2x10 + "";
            String y2y1as = y2y10 + "";
            String y02s = y0001.ToString("+ #;- #;0");
            String x02s = x0001.ToString("+ #;- #;0");
            String yi3s = x2x10.ToString("#;- #;0") + "Y";
            String xi3s = y2y10 + "X";
            String y03x2x1s = x2x1c.ToString("+ #;- #;0");
            String x03y2y1s = y2y1c.ToString("+ #;- #;0");
            String xi4s = x03.ToString("#;- #;0") + "X";
            String yi4s = y03.ToString("+ #;- #;0") + "Y";
            String x03y03s = indepA.ToString("+ #;- #;0");
            String xi5s = x03.ToString("#;- #;0") + "X";
            String yi5s = y03.ToString("+ #;- #;0") + "Y";
            String InverseSignx03y03s = indepB + "";

            int Div = 1;
            Divisor.Text = "1";
            int xa6 = x03 / Div;
            int ya6 = y03 / Div;
            int x3y46 = indepA / Div;

            //6 Strings p1 EQ6
            String xi6s = xa6.ToString("#;- #;0") + "X";
            String yi6s = ya6.ToString("+ #;- #;0") + "Y";
            String x03y4s = x3y46.ToString("+ #;- #;0");

            int x3y47 = indepB / Div;
            //6 Strings p2 EQ7
            String xi7s = xa6.ToString("#;- #;0") + "X";
            String yi7s = ya6.ToString("+ #;- #;0") + "Y";
            String InverseSignx03y4s = x3y47 + "";

            //testXY
            EQ1part1.Text = "Y" + " " + y01s;
            EQ1part2.Text = ya2s + " " + ya1s;
            EQ1part3.Text = xa2s + " " + xa1s;
            EQ1part4.Text = "(" + "X" + " " + x01s + ")";
            EQ2part1.Text = "Y" + " " + y02s;
            EQ2part2.Text = y2y1as;
            EQ2part3.Text = x2x1as;
            EQ2part4.Text = "(" + "X" + " " + x02s + ")";
            EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
            EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = 0";
            EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
            EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = 0";
            EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
        }
        public void DivIsEmptyEqualsNothing() //Text Change if Div is blank, Div is 1
        {
            int x0001v2 = Bulbasaur; // Valor de X1
            int y0001v2 = Charmander; // Valor de Y1
            int x0002 = Squirtle; // Valor de X2
            int y0002 = Pikachu; // Valor de Y2
            int x0001 = Bulbasaur * -1; // * -1
            int y0001 = Charmander * -1; // * -1
            int x2x10 = x0002 - x0001v2;
            int y2y10 = y0002 - y0001v2;
            int x2x1c = y0001 * x2x10;
            int y2y1c = x0001 * y2y10;
            int indepA = x2x1c - y2y1c;
            int indepB = indepA * -1;
            int x03 = y2y10 * -1;
            int y03 = x2x10;
            String xa1s = x0001.ToString("+ #;- #;0");
            String ya1s = y0001.ToString("+ #;- #;0");
            String xa2s = x0002 + "";
            String ya2s = y0002 + "";
            String y01s = y0001.ToString("+ #;- #;0");
            String x01s = x0001.ToString("+ #;- #;0");
            String x2x1as = x2x10 + "";
            String y2y1as = y2y10 + "";
            String y02s = y0001.ToString("+ #;- #;0");
            String x02s = x0001.ToString("+ #;- #;0");
            String yi3s = x2x10.ToString("#;- #;0") + "Y";
            String xi3s = y2y10 + "X";
            String y03x2x1s = x2x1c.ToString("+ #;- #;0");
            String x03y2y1s = y2y1c.ToString("+ #;- #;0");
            String xi4s = x03.ToString("#;- #;0") + "X";
            String yi4s = y03.ToString("+ #;- #;0") + "Y";
            String x03y03s = indepA.ToString("+ #;- #;0");
            String xi5s = x03.ToString("#;- #;0") + "X";
            String yi5s = y03.ToString("+ #;- #;0") + "Y";
            String InverseSignx03y03s = indepB + "";
            
            int Div = 1;
            int xa6 = x03 / Div;
            int ya6 = y03 / Div;
            int x3y46 = indepA / Div;

            //6 Strings p1 EQ6
            String xi6s = xa6.ToString("#;- #;0") + "X";
            String yi6s = ya6.ToString("+ #;- #;0") + "Y";
            String x03y4s = x3y46.ToString("+ #;- #;0");

            int x3y47 = indepB / Div;
            //6 Strings p2 EQ7
            String xi7s = xa6.ToString("#;- #;0") + "X";
            String yi7s = ya6.ToString("+ #;- #;0") + "Y";
            String InverseSignx03y4s = x3y47 + "";

            //testXY
            EQ1part1.Text = "Y" + " " + y01s;
            EQ1part2.Text = ya2s + " " + ya1s;
            EQ1part3.Text = xa2s + " " + xa1s;
            EQ1part4.Text = "(" + "X" + " " + x01s + ")";
            EQ2part1.Text = "Y" + " " + y02s;
            EQ2part2.Text = y2y1as;
            EQ2part3.Text = x2x1as;
            EQ2part4.Text = "(" + "X" + " " + x02s + ")";
            EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
            EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = 0";
            EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
            EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = 0";
            EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
        }
        public void DivIsNumber() //Div is #
        {
            int x0001v2 = Bulbasaur; // Valor de X1
            int y0001v2 = Charmander; // Valor de Y1
            int x0002 = Squirtle; // Valor de X2
            int y0002 = Pikachu; // Valor de Y2
            int x0001 = Bulbasaur * -1; // * -1
            int y0001 = Charmander * -1; // * -1
            int x2x10 = x0002 - x0001v2;
            int y2y10 = y0002 - y0001v2;
            int x2x1c = y0001 * x2x10;
            int y2y1c = x0001 * y2y10;
            int indepA = x2x1c - y2y1c;
            int indepB = indepA * -1;
            int x03 = y2y10 * -1;
            int y03 = x2x10;
            String xa1s = x0001.ToString("+ #;- #;0");
            String ya1s = y0001.ToString("+ #;- #;0");
            String xa2s = x0002 + "";
            String ya2s = y0002 + "";
            String y01s = y0001.ToString("+ #;- #;0");
            String x01s = x0001.ToString("+ #;- #;0");
            String x2x1as = x2x10 + "";
            String y2y1as = y2y10 + "";
            String y02s = y0001.ToString("+ #;- #;0");
            String x02s = x0001.ToString("+ #;- #;0");
            String yi3s = x2x10.ToString("#;- #;0") + "Y";
            String xi3s = y2y10 + "X";
            String y03x2x1s = x2x1c.ToString("+ #;- #;0");
            String x03y2y1s = y2y1c.ToString("+ #;- #;0");
            String xi4s = x03.ToString("#;- #;0") + "X";
            String yi4s = y03.ToString("+ #;- #;0") + "Y";
            String x03y03s = indepA.ToString("+ #;- #;0");
            String xi5s = x03.ToString("#;- #;0") + "X";
            String yi5s = y03.ToString("+ #;- #;0") + "Y";
            String InverseSignx03y03s = indepB + "";

            int Div = Int32.Parse(Divisor.Text);
            int xa6 = x03 / Div;
            int ya6 = y03 / Div;
            int x3y46 = indepA / Div;

            //6 Strings p1 EQ6
            String xi6s = xa6.ToString("#;- #;0") + "X";
            String yi6s = ya6.ToString("+ #;- #;0") + "Y";
            String x03y4s = x3y46.ToString("+ #;- #;0");

            int x3y47 = indepB / Div;
            //6 Strings p2 EQ7
            String xi7s = xa6.ToString("#;- #;0") + "X";
            String yi7s = ya6.ToString("+ #;- #;0") + "Y";
            String InverseSignx03y4s = x3y47 + "";

            //testXY
            EQ1part1.Text = "Y" + " " + y01s;
            EQ1part2.Text = ya2s + " " + ya1s;
            EQ1part3.Text = xa2s + " " + xa1s;
            EQ1part4.Text = "(" + "X" + " " + x01s + ")";
            EQ2part1.Text = "Y" + " " + y02s;
            EQ2part2.Text = y2y1as;
            EQ2part3.Text = x2x1as;
            EQ2part4.Text = "(" + "X" + " " + x02s + ")";
            EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
            EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = 0";
            EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
            EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = 0";
            EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
        }

        #region Main Method Line Equation 1
        public void MainMLE1()
        {
            try
            {
                MainMethodFirstPart();
                
                //6 Dividiento todo por #
                if (String.IsNullOrWhiteSpace(Divisor.Text))
                {
                    DivIsEmptyEquals1();
                }
                else
                {
                    DivIsNumber();
                }
            }
            catch
            {
                MessageBox.Show("Sólo números",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Divisor Method
        public void DivisorMLE1_1(object sender, EventArgs e)
        {
            try
            {
                MainMethodFirstPart();

                //6 Dividiento todo por #
                if (String.IsNullOrWhiteSpace(Divisor.Text))
                {
                    DivIsEmptyEqualsNothing();
                }
                else
                {
                    DivIsNumber();
                }
            }
            catch
            {
                MessageBox.Show("Sólo números",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region KeyDown Methods
        private void x1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Up)
            {
                int asd1 = Int32.Parse(x1.Text) + 1;
                x1.Text = asd1 + "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                int asd1 = Int32.Parse(x1.Text) - 1;
                x1.Text = asd1 + "";
            }
        }
        private void y1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Up)
            {
                int asd1 = Int32.Parse(y1.Text) + 1;
                y1.Text = asd1 + "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                int asd1 = Int32.Parse(y1.Text) - 1;
                y1.Text = asd1 + "";
            }
        }
        private void x2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Up)
            {
                int asd1 = Int32.Parse(x2.Text) + 1;
                x2.Text = asd1 + "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                int asd1 = Int32.Parse(x2.Text) - 1;
                x2.Text = asd1 + "";
            }
        }
        private void y2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Up)
            {
                int asd1 = Int32.Parse(y2.Text) + 1;
                y2.Text = asd1 + "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                int asd1 = Int32.Parse(y2.Text) - 1;
                y2.Text = asd1 + "";
            }
        }
        private void Divisor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Up)
            {
                int asd1 = Int32.Parse(Divisor.Text) + 1;
                Divisor.Text = asd1 + "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                int asd1 = Int32.Parse(Divisor.Text) - 1;
                Divisor.Text = asd1 + "";
            }
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion

        #region MouseWheel Methods
        private void x1_MouseWH(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                int x941a = Int32.Parse(x1.Text) + 1;
                x1.Text = x941a + "";
            }
            else if (e.Delta < 0)
            {
                int x941b = Int32.Parse(x1.Text) - 1;
                x1.Text = x941b + "";
            }
        }
        private void y1_MouseWH(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                int y941a = Int32.Parse(y1.Text) + 1;
                y1.Text = y941a + "";
            }
            else if (e.Delta < 0)
            {
                int y941b = Int32.Parse(y1.Text) - 1;
                y1.Text = y941b + "";
            }
        }
        private void x2_MouseWH(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                int x942a = Int32.Parse(x2.Text) + 1;
                x2.Text = x942a + "";
            }
            else if (e.Delta < 0)
            {
                int x942b = Int32.Parse(x2.Text) - 1;
                x2.Text = x942b + "";
            }
        }
        private void y2_MouseWH(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                int y942a = Int32.Parse(y2.Text) + 1;
                y2.Text = y942a + "";
            }
            else if (e.Delta < 0)
            {
                int y942b = Int32.Parse(y2.Text) - 1;
                y2.Text = y942b + "";
            }
        }
        private void Div_MouseWH(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                int div94a = Int32.Parse(Divisor.Text) + 1;
                Divisor.Text = div94a + "";
            }
            else if (e.Delta < 0)
            {
                int div94b = Int32.Parse(Divisor.Text) - 1;
                Divisor.Text = div94b + "";
            }
        }
        #endregion

        #region ToolTips when hovering mouse
        private void x1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip TT = new System.Windows.Forms.ToolTip();
            TT.SetToolTip(this.x1, "X del punto 1");
        }
        private void y1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip TT = new System.Windows.Forms.ToolTip();
            TT.SetToolTip(this.y1, "Y del punto 1");
        }
        private void x2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip TT = new System.Windows.Forms.ToolTip();
            TT.SetToolTip(this.x2, "X del punto 2");
        }
        private void y2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip TT = new System.Windows.Forms.ToolTip();
            TT.SetToolTip(this.y2, "Y del punto 2");
        }
        private void Divisor_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip TT = new System.Windows.Forms.ToolTip();
            TT.SetToolTip(this.y2, "Divisor de toda la función");
        }
        #endregion

        #region Methods_Run
        private void MainMLE1_Run(object sender, EventArgs e)
        {
            MainMLE1();
        }
        #endregion

        #region Button1 Method
        private void button1_Click(object sender, EventArgs e)
        {
            int x0001v2 = Bulbasaur; // Valor de X1
            int y0001v2 = Charmander; // Valor de Y1
            int x0002 = Squirtle; // Valor de X2
            int y0002 = Pikachu; // Valor de Y2
            int x0001 = Bulbasaur * -1; // * -1
            int y0001 = Charmander * -1*0; // * -1
            int x2x10 = x0002 - x0001v2;
            int y2y10 = y0002 - y0001v2;
            int y2y1c = x0001 * y2y10;
            int x2x1c = y0001 * x2x10;
            int indepA = x2x1c - y2y1c;
            int indepB = indepA * -1;
            int x03 = y2y10 * -1;
            int y03 = x2x10;
            int Div = Int32.Parse(Divisor.Text);
            int x3y46 = indepA / Div;
            int xa6 = x03 / Div;
            int ya6 = y03 / Div;
            int x3y47 = indepB / Div;

            //int Div = 1;
            //int xa6 = 0 / Div;
            //int ya6 = 2 / Div;
            //int x3y46 = -10 / Div;
            //int x3y47 = 10 / Div;

            if (Bulbasaur == 0 || (xa6 != Bulbasaur && xa6 != (Bulbasaur * -1)))
            {
                Bulbasaur = xa6;
            }
            if (Charmander == 0 || (ya6 != Charmander && ya6 != (Charmander * -1)))
            {
                Charmander = ya6;
            }
            if (Squirtle == 0 || (x3y46 != Squirtle && x3y46 != (Squirtle * -1)))
            {
                Squirtle = x3y46;
            }
            if (Pikachu == 0 || (x3y47 != Pikachu && x3y47 != (Pikachu * -1)))
            {
                Pikachu = x3y47;
            }
            Bulbasaur *= -1;
            Charmander *= -1;
            Squirtle *= -1;
            Pikachu *= -1;

            String Venusaur = Bulbasaur.ToString("#;- #;0");
            String Charizard = Charmander.ToString("+ #;- #;0");
            String Blastoise = Squirtle.ToString("+ #;- #;0");
            String Raichu = Pikachu + "";

            EQ6.Text = Venusaur + "X " + Charizard + "Y " + Blastoise + " = 0";
            EQ7.Text = Venusaur + "X " + Charizard + "Y = " + Raichu;
        }
        #endregion
    }
}