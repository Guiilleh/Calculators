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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        #region Main Method Test 1
        private void MainMTest1()
        {
            try
            {
                int asd = Int32.Parse(ok1.Text);
                okay1.Text = asd + "";
            }
            catch
            {
                return;
                /*MessageBox.Show("Sólo números",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);*/
            }
        }
        #endregion

        #region Main Method Test 2
        private void MainMTest2()
        {
            try
            {
                //method 1
                int test1 = Int32.Parse(number1.Text);
                if (test1 > 0)
                {
                    result1.Text = "+" + test1;
                }
                else
                {
                    result1.Text = "" + test1;
                }

                //method 2
                int test2 = Int32.Parse(number2.Text);
                result2.Text = test2.ToString("+#;-#;0");

                //method 3
                result3.Text = Int32.Parse(number3.Text).ToString("+#;-#;0");
            }
            catch
            {
                MessageBox.Show("Sólo números",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }//MainMTest2 END
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

        #region Methods_Run
        private void MainMTest1_Run(object sender, EventArgs e)
        {
            MainMTest1();
        }
        private void MainMTest2_Run(object sender, EventArgs e)
        {
            MainMTest2();
        }
        #endregion

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.K)
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                int asd1 = Int32.Parse(textBox1.Text) + 1;
                textBox1.Text = asd1 + "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                int asd1 = Int32.Parse(textBox1.Text) - 1;
                textBox1.Text = asd1 + "";
            }
        }
    }
}