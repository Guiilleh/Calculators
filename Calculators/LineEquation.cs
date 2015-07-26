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
        public LineEquation()
        {
            InitializeComponent();
        }

        #region Main Method Line Equation 1
        public void MainMLE1()
        {
            try
            {
                //1
                int x0001v2 = Int32.Parse(x1.Text);// Valor de X1
                int x0001 = x0001v2 * -1; // * -1
                int y0001v2 = Int32.Parse(y1.Text); // Valor de Y1
                int y0001 = y0001v2 * -1; // * -1
                int x0002 = Int32.Parse(x2.Text); // Valor de X2
                int y0002 = Int32.Parse(y2.Text); // Valor de Y2
                //1 Strings EQ1
                String xi1s = "X";
                String yi1s = "Y";
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
                int zero = 0;
                //4 Strings EQ4
                String xi4s = x03.ToString("#;- #;0") + "X";
                String yi4s = y03.ToString("+ #;- #;0") + "Y";
                String x03y03s = indepA.ToString("+ #;- #;0");
                String zero1s = zero + "";

                //5
                int indepB = indepA * -1;
                //5 Strings EQ5
                String xi5s = x03.ToString("#;- #;0") + "X";
                String yi5s = y03.ToString("+ #;- #;0") + "Y";
                String InverseSignx03y03s = indepB + "";
                
                //6 Dividiento todo por #
                int Div = Int32.Parse(Divisor.Text);
                int xa6 = x03 / Div;
                int ya6 = y03 / Div;
                int x3y46 = indepA / Div;
                //6 Strings p1 EQ6
                String xi6s = xa6.ToString("#;- #;0") + "X";
                String yi6s = ya6.ToString("+ #;- #;0") + "Y";
                String x03y4s = x3y46.ToString("+ #;- #;0");
                String zero2s = zero / Div + "";

                int x3y47 = indepB / Div;
                //6 Strings p2 EQ7
                String xi7s = xa6.ToString("#;- #;0") + "X";
                String yi7s = ya6.ToString("+ #;- #;0") + "Y";
                String InverseSignx03y4s = x3y47 + "";

                //7 Multiplicando todo por -1
                int x08 = xa6 * -1;
                int y08 = ya6 * -1;
                int x03y58 = x3y46 * -1;
                //7 Strings p1 EQ8
                String xi8s = x08.ToString("#;- #;0") + "X";
                String yi8s = y08.ToString("+ #;- #;0") + "Y";
                String x03y5s = x03y58.ToString("+ #;- #;0") + "";
                String zero3s = zero * -1 + "";

                int x09 = xa6 * -1;
                int y09 = ya6 * -1;
                //7 Strings p2 EQ9
                String xi9s = x09.ToString("#;- #;0") + "X";
                String yi9s = y09.ToString("+ #;- #;0") + "Y";
                String InverseSignx03y5s = x3y47 * -1 + "";

                //testXY
                EQ1part1.Text = yi1s + " " + y01s;
                EQ1part2.Text = ya2s + " " + ya1s;
                EQ1part3.Text = xa2s + " " + xa1s;
                EQ1part4.Text = "(" + xi1s + " " + x01s + ")";
                EQ2part1.Text = yi1s + " " + y02s;
                EQ2part2.Text = y2y1as;
                EQ2part3.Text = x2x1as;
                EQ2part4.Text = "(" + xi1s + " " + x02s + ")";
                EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
                EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = " + zero1s;
                EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
                EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = " + zero2s;
                EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
                EQ8.Text = xi8s + " " + yi8s + " " + x03y5s + " = " + zero3s;
                EQ9.Text = xi9s + " " + yi9s + " = " + InverseSignx03y5s;
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
        /*public void DivisorMLE1(object sender, EventArgs e)
        {
            try
            {
                //1
                int x0001v2 = Int32.Parse(x1.Text);// Valor de X1
                int x0001 = x0001v2 * -1; // *-1
                int y0001v2 = Int32.Parse(y1.Text); // Valor de Y1
                int y0001 = y0001v2 * -1; // *-1
                int x0002 = Int32.Parse(x2.Text); // Valor de X2
                int y0002 = Int32.Parse(y2.Text); // Valor de Y2
                //1 Strings EQ1
                String xi1s = "X";
                String yi1s = "Y";
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
                int zero = 0;
                //4 Strings EQ4
                String xi4s = x03.ToString("#;- #;0") + "X";
                String yi4s = y03.ToString("+ #;- #;0") + "Y";
                String x03y03s = indepA.ToString("+ #;- #;0");
                String zero1s = zero + "";

                //5
                int indepB = indepA * -1;
                //5 Strings EQ5
                String xi5s = x03.ToString("#;- #;0") + "X";
                String yi5s = y03.ToString("+ #;- #;0") + "Y";
                String InverseSignx03y03s = indepB + "";

                //6 Dividiento todo por #
                if (String.IsNullOrWhiteSpace(Divisor.Text))
                {
                    int Div = 1;
                    Divisor.Text = "1";
                    int xa6 = x03 / Div;
                    int ya6 = y03 / Div;
                    int x3y46 = indepA / Div;
                    //6 Strings p1 EQ6
                    String xi6s = xa6.ToString("#;- #;0") + "X";
                    String yi6s = ya6.ToString("+ #;- #;0") + "Y";
                    String x03y4s = x3y46.ToString("+ #;- #;0");
                    String zero2s = zero / Div + "";

                    int x3y47 = indepB / Div;
                    //6 Strings p2 EQ7
                    String xi7s = xa6.ToString("#;- #;0") + "X";
                    String yi7s = ya6.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y4s = x3y47 + "";

                    //7 Multiplicando todo por -1
                    int x08 = xa6 * -1;
                    int y08 = ya6 * -1;
                    int x03y58 = x3y46 * -1;
                    //7 Strings p1 EQ8
                    String xi8s = x08.ToString("#;- #;0") + "X";
                    String yi8s = y08.ToString("+ #;- #;0") + "Y";
                    String x03y5s = x03y58.ToString("+ #;- #;0") + "";
                    String zero3s = zero * -1 + "";

                    int x09 = xa6 * -1;
                    int y09 = ya6 * -1;
                    //7 Strings p2 EQ9
                    String xi9s = x09.ToString("#;- #;0") + "X";
                    String yi9s = y09.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y5s = x3y47 * -1 + "";

                    //testXY
                    EQ1part1.Text = yi1s + " " + y01s;
                    EQ1part2.Text = ya2s + " " + ya1s;
                    EQ1part3.Text = xa2s + " " + xa1s;
                    EQ1part4.Text = "(" + xi1s + " " + x01s + ")";
                    EQ2part1.Text = yi1s + " " + y02s;
                    EQ2part2.Text = y2y1as;
                    EQ2part3.Text = x2x1as;
                    EQ2part4.Text = "(" + xi1s + " " + x02s + ")";
                    EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
                    EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = " + zero1s;
                    EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
                    EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = " + zero2s;
                    EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
                    EQ8.Text = xi8s + " " + yi8s + " " + x03y5s + " = " + zero3s;
                    EQ9.Text = xi9s + " " + yi9s + " = " + InverseSignx03y5s;
                }
                else
                {
                    int Div = Int32.Parse(Divisor.Text);
                    int xa6 = x03 / Div;
                    int ya6 = y03 / Div;
                    int x3y46 = indepA / Div;
                    //6 Strings p1 EQ6
                    String xi6s = xa6.ToString("#;- #;0") + "X";
                    String yi6s = ya6.ToString("+ #;- #;0") + "Y";
                    String x03y4s = x3y46.ToString("+ #;- #;0");
                    String zero2s = zero / Div + "";

                    int x3y47 = indepB / Div;
                    //6 Strings p2 EQ7
                    String xi7s = xa6.ToString("#;- #;0") + "X";
                    String yi7s = ya6.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y4s = x3y47 + "";

                    //7 Multiplicando todo por -1
                    int x08 = xa6 * -1;
                    int y08 = ya6 * -1;
                    int x03y58 = x3y46 * -1;
                    //7 Strings p1 EQ8
                    String xi8s = x08.ToString("#;- #;0") + "X";
                    String yi8s = y08.ToString("+ #;- #;0") + "Y";
                    String x03y5s = x03y58.ToString("+ #;- #;0") + "";
                    String zero3s = zero * -1 + "";

                    int x09 = xa6 * -1;
                    int y09 = ya6 * -1;
                    //7 Strings p2 EQ9
                    String xi9s = x09.ToString("#;- #;0") + "X";
                    String yi9s = y09.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y5s = x3y47 * -1 + "";

                    //testXY
                    EQ1part1.Text = yi1s + " " + y01s;
                    EQ1part2.Text = ya2s + " " + ya1s;
                    EQ1part3.Text = xa2s + " " + xa1s;
                    EQ1part4.Text = "(" + xi1s + " " + x01s + ")";
                    EQ2part1.Text = yi1s + " " + y02s;
                    EQ2part2.Text = y2y1as;
                    EQ2part3.Text = x2x1as;
                    EQ2part4.Text = "(" + xi1s + " " + x02s + ")";
                    EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
                    EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = " + zero1s;
                    EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
                    EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = " + zero2s;
                    EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
                    EQ8.Text = xi8s + " " + yi8s + " " + x03y5s + " = " + zero3s;
                    EQ9.Text = xi9s + " " + yi9s + " = " + InverseSignx03y5s;
                }
            }
            catch
            {
                MessageBox.Show("Sólo números",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }*/


        public void DivisorMLE1_1(object sender, EventArgs e)
        {
            try
            {
                //1
                int x0001v2 = Int32.Parse(x1.Text);// Valor de X1
                int x0001 = x0001v2 * -1; // *-1
                int y0001v2 = Int32.Parse(y1.Text); // Valor de Y1
                int y0001 = y0001v2 * -1; // *-1
                int x0002 = Int32.Parse(x2.Text); // Valor de X2
                int y0002 = Int32.Parse(y2.Text); // Valor de Y2
                //1 Strings EQ1
                String xi1s = "X";
                String yi1s = "Y";
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
                int zero = 0;
                //4 Strings EQ4
                String xi4s = x03.ToString("#;- #;0") + "X";
                String yi4s = y03.ToString("+ #;- #;0") + "Y";
                String x03y03s = indepA.ToString("+ #;- #;0");
                String zero1s = zero + "";

                //5
                int indepB = indepA * -1;
                //5 Strings EQ5
                String xi5s = x03.ToString("#;- #;0") + "X";
                String yi5s = y03.ToString("+ #;- #;0") + "Y";
                String InverseSignx03y03s = indepB + "";

                //6 Dividiento todo por #
                if (String.IsNullOrWhiteSpace(Divisor.Text))
                {
                    int Div = 1;
                    int xa6 = x03 / Div;
                    int ya6 = y03 / Div;
                    int x3y46 = indepA / Div;
                    //6 Strings p1 EQ6
                    String xi6s = xa6.ToString("#;- #;0") + "X";
                    String yi6s = ya6.ToString("+ #;- #;0") + "Y";
                    String x03y4s = x3y46.ToString("+ #;- #;0");
                    String zero2s = zero / Div + "";

                    int x3y47 = indepB / Div;
                    //6 Strings p2 EQ7
                    String xi7s = xa6.ToString("#;- #;0") + "X";
                    String yi7s = ya6.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y4s = x3y47 + "";

                    //7 Multiplicando todo por -1
                    int x08 = xa6 * -1;
                    int y08 = ya6 * -1;
                    int x03y58 = x3y46 * -1;
                    //7 Strings p1 EQ8
                    String xi8s = x08.ToString("#;- #;0") + "X";
                    String yi8s = y08.ToString("+ #;- #;0") + "Y";
                    String x03y5s = x03y58.ToString("+ #;- #;0") + "";
                    String zero3s = zero * -1 + "";

                    int x09 = xa6 * -1;
                    int y09 = ya6 * -1;
                    //7 Strings p2 EQ9
                    String xi9s = x09.ToString("#;- #;0") + "X";
                    String yi9s = y09.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y5s = x3y47 * -1 + "";

                    //testXY
                    EQ1part1.Text = yi1s + " " + y01s;
                    EQ1part2.Text = ya2s + " " + ya1s;
                    EQ1part3.Text = xa2s + " " + xa1s;
                    EQ1part4.Text = "(" + xi1s + " " + x01s + ")";
                    EQ2part1.Text = yi1s + " " + y02s;
                    EQ2part2.Text = y2y1as;
                    EQ2part3.Text = x2x1as;
                    EQ2part4.Text = "(" + xi1s + " " + x02s + ")";
                    EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
                    EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = " + zero1s;
                    EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
                    EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = " + zero2s;
                    EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
                    EQ8.Text = xi8s + " " + yi8s + " " + x03y5s + " = " + zero3s;
                    EQ9.Text = xi9s + " " + yi9s + " = " + InverseSignx03y5s;
                }
                else
                {
                    int Div = Int32.Parse(Divisor.Text);
                    int xa6 = x03 / Div;
                    int ya6 = y03 / Div;
                    int x3y46 = indepA / Div;
                    //6 Strings p1 EQ6
                    String xi6s = xa6.ToString("#;- #;0") + "X";
                    String yi6s = ya6.ToString("+ #;- #;0") + "Y";
                    String x03y4s = x3y46.ToString("+ #;- #;0");
                    String zero2s = zero / Div + "";

                    int x3y47 = indepB / Div;
                    //6 Strings p2 EQ7
                    String xi7s = xa6.ToString("#;- #;0") + "X";
                    String yi7s = ya6.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y4s = x3y47 + "";

                    //7 Multiplicando todo por -1
                    int x08 = xa6 * -1;
                    int y08 = ya6 * -1;
                    int x03y58 = x3y46 * -1;
                    //7 Strings p1 EQ8
                    String xi8s = x08.ToString("#;- #;0") + "X";
                    String yi8s = y08.ToString("+ #;- #;0") + "Y";
                    String x03y5s = x03y58.ToString("+ #;- #;0") + "";
                    String zero3s = zero * -1 + "";

                    int x09 = xa6 * -1;
                    int y09 = ya6 * -1;
                    //7 Strings p2 EQ9
                    String xi9s = x09.ToString("#;- #;0") + "X";
                    String yi9s = y09.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y5s = x3y47 * -1 + "";

                    //testXY
                    EQ1part1.Text = yi1s + " " + y01s;
                    EQ1part2.Text = ya2s + " " + ya1s;
                    EQ1part3.Text = xa2s + " " + xa1s;
                    EQ1part4.Text = "(" + xi1s + " " + x01s + ")";
                    EQ2part1.Text = yi1s + " " + y02s;
                    EQ2part2.Text = y2y1as;
                    EQ2part3.Text = x2x1as;
                    EQ2part4.Text = "(" + xi1s + " " + x02s + ")";
                    EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
                    EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = " + zero1s;
                    EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
                    EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = " + zero2s;
                    EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
                    EQ8.Text = xi8s + " " + yi8s + " " + x03y5s + " = " + zero3s;
                    EQ9.Text = xi9s + " " + yi9s + " = " + InverseSignx03y5s;
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

        public void DivisorMLE1_2(object sender, EventArgs e)
        {
            try
            {
                //1
                int x0001v2 = Int32.Parse(x1.Text);// Valor de X1
                int x0001 = x0001v2 * -1; // *-1
                int y0001v2 = Int32.Parse(y1.Text); // Valor de Y1
                int y0001 = y0001v2 * -1; // *-1
                int x0002 = Int32.Parse(x2.Text); // Valor de X2
                int y0002 = Int32.Parse(y2.Text); // Valor de Y2
                //1 Strings EQ1
                String xi1s = "X";
                String yi1s = "Y";
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
                int zero = 0;
                //4 Strings EQ4
                String xi4s = x03.ToString("#;- #;0") + "X";
                String yi4s = y03.ToString("+ #;- #;0") + "Y";
                String x03y03s = indepA.ToString("+ #;- #;0");
                String zero1s = zero + "";

                //5
                int indepB = indepA * -1;
                //5 Strings EQ5
                String xi5s = x03.ToString("#;- #;0") + "X";
                String yi5s = y03.ToString("+ #;- #;0") + "Y";
                String InverseSignx03y03s = indepB + "";

                //6 Dividiento todo por #
                if (String.IsNullOrWhiteSpace(Divisor.Text))
                {
                    int Div = 1;
                    Divisor.Text = "1";
                    int xa6 = x03 / Div;
                    int ya6 = y03 / Div;
                    int x3y46 = indepA / Div;
                    //6 Strings p1 EQ6
                    String xi6s = xa6.ToString("#;- #;0") + "X";
                    String yi6s = ya6.ToString("+ #;- #;0") + "Y";
                    String x03y4s = x3y46.ToString("+ #;- #;0");
                    String zero2s = zero / Div + "";

                    int x3y47 = indepB / Div;
                    //6 Strings p2 EQ7
                    String xi7s = xa6.ToString("#;- #;0") + "X";
                    String yi7s = ya6.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y4s = x3y47 + "";

                    //7 Multiplicando todo por -1
                    int x08 = xa6 * -1;
                    int y08 = ya6 * -1;
                    int x03y58 = x3y46 * -1;
                    //7 Strings p1 EQ8
                    String xi8s = x08.ToString("#;- #;0") + "X";
                    String yi8s = y08.ToString("+ #;- #;0") + "Y";
                    String x03y5s = x03y58.ToString("+ #;- #;0") + "";
                    String zero3s = zero * -1 + "";

                    int x09 = xa6 * -1;
                    int y09 = ya6 * -1;
                    //7 Strings p2 EQ9
                    String xi9s = x09.ToString("#;- #;0") + "X";
                    String yi9s = y09.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y5s = x3y47 * -1 + "";

                    //testXY
                    EQ1part1.Text = yi1s + " " + y01s;
                    EQ1part2.Text = ya2s + " " + ya1s;
                    EQ1part3.Text = xa2s + " " + xa1s;
                    EQ1part4.Text = "(" + xi1s + " " + x01s + ")";
                    EQ2part1.Text = yi1s + " " + y02s;
                    EQ2part2.Text = y2y1as;
                    EQ2part3.Text = x2x1as;
                    EQ2part4.Text = "(" + xi1s + " " + x02s + ")";
                    EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
                    EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = " + zero1s;
                    EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
                    EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = " + zero2s;
                    EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
                    EQ8.Text = xi8s + " " + yi8s + " " + x03y5s + " = " + zero3s;
                    EQ9.Text = xi9s + " " + yi9s + " = " + InverseSignx03y5s;
                }
                else
                {
                    int Div = Int32.Parse(Divisor.Text);
                    int xa6 = x03 / Div;
                    int ya6 = y03 / Div;
                    int x3y46 = indepA / Div;
                    //6 Strings p1 EQ6
                    String xi6s = xa6.ToString("#;- #;0") + "X";
                    String yi6s = ya6.ToString("+ #;- #;0") + "Y";
                    String x03y4s = x3y46.ToString("+ #;- #;0");
                    String zero2s = zero / Div + "";

                    int x3y47 = indepB / Div;
                    //6 Strings p2 EQ7
                    String xi7s = xa6.ToString("#;- #;0") + "X";
                    String yi7s = ya6.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y4s = x3y47 + "";

                    //7 Multiplicando todo por -1
                    int x08 = xa6 * -1;
                    int y08 = ya6 * -1;
                    int x03y58 = x3y46 * -1;
                    //7 Strings p1 EQ8
                    String xi8s = x08.ToString("#;- #;0") + "X";
                    String yi8s = y08.ToString("+ #;- #;0") + "Y";
                    String x03y5s = x03y58.ToString("+ #;- #;0") + "";
                    String zero3s = zero * -1 + "";

                    int x09 = xa6 * -1;
                    int y09 = ya6 * -1;
                    //7 Strings p2 EQ9
                    String xi9s = x09.ToString("#;- #;0") + "X";
                    String yi9s = y09.ToString("+ #;- #;0") + "Y";
                    String InverseSignx03y5s = x3y47 * -1 + "";

                    //testXY
                    EQ1part1.Text = yi1s + " " + y01s;
                    EQ1part2.Text = ya2s + " " + ya1s;
                    EQ1part3.Text = xa2s + " " + xa1s;
                    EQ1part4.Text = "(" + xi1s + " " + x01s + ")";
                    EQ2part1.Text = yi1s + " " + y02s;
                    EQ2part2.Text = y2y1as;
                    EQ2part3.Text = x2x1as;
                    EQ2part4.Text = "(" + xi1s + " " + x02s + ")";
                    EQ3.Text = yi3s + " " + y03x2x1s + " = " + xi3s + " " + x03y2y1s;
                    EQ4.Text = xi4s + " " + yi4s + " " + x03y03s + " = " + zero1s;
                    EQ5.Text = xi5s + " " + yi5s + " = " + InverseSignx03y03s;
                    EQ6.Text = xi6s + " " + yi6s + " " + x03y4s + " = " + zero2s;
                    EQ7.Text = xi7s + " " + yi7s + " = " + InverseSignx03y4s;
                    EQ8.Text = xi8s + " " + yi8s + " " + x03y5s + " = " + zero3s;
                    EQ9.Text = xi9s + " " + yi9s + " = " + InverseSignx03y5s;
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
        /*private void div_run(object sender, EventArgs e)
        {
            DivisorMLE1();
        }*/
        #endregion
    }
}