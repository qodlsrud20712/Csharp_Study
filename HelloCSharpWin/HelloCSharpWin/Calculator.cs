using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public float Add(float num1, float num2)
        {
            float sum = num1 + num2;
            return sum;
        }

        public int Sub(int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }
        public int Mul(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }

        public int Div(int num1, int num2)
        {
            int sum = num1/num2;
            return sum;
        }


        private void num1_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("2");
        }

        public void SetNum(string num)
        {
            if (numscreen.Text == "0")
            {
                numscreen.Text = num;
                Operation.Text = num;
            }
            else
            {
                numscreen.Text = numscreen.Text + num;
                Operation.Text = Operation.Text + num;
            }

        }

        private void numplus_Click(object sender, EventArgs e)
        {   
            if(Operation.Text != "")
            {
                Operation.Text = Operation.Text + "+";
            }
            else
            {
                Operation.Text = numscreen.Text + "+";
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            string OperText;
            OperText = Operation.Text;
            string plus = "+";
            string minus = "-";
            string mul = "*";
            string div = "/";
            if(OperText.Contains(plus))
            {
                string[] res = OperText.Split('+');
                int.TryParse(res[0], out num1);
                int.TryParse(res[1], out num2);
                int sum = Add(num1, num2);
                numscreen.Text = sum.ToString();
            }
            else if (OperText.Contains(minus))
            {
                string[] res = OperText.Split('-');
                int.TryParse(res[0], out num1);
                int.TryParse(res[1], out num2);
                int sum = Sub(num1, num2);
                numscreen.Text = sum.ToString();
            }
            else if (OperText.Contains(mul))
            {
                string[] res = OperText.Split('*');
                int.TryParse(res[0], out num1);
                int.TryParse(res[1], out num2);
                int sum = Mul(num1, num2);
                numscreen.Text = sum.ToString();
            }
            else if (OperText.Contains(div))
            {
                string[] res = OperText.Split('/');
                int.TryParse(res[0], out num1);
                int.TryParse(res[1], out num2);
                int sum = Div(num1, num2);
                numscreen.Text = sum.ToString();
            }

            //OperText.Replace("+-*/", "");
            Operation.Text = "";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("9");
        }

        private void num0_Click(object sender, EventArgs e)
        {
            numscreen.Text = "";
            SetNum("0");
        }

        private void numsub_Click(object sender, EventArgs e)
        {
            if (Operation.Text != "")
            {
                Operation.Text = Operation.Text + "-";
            }
            else
            {
                Operation.Text = numscreen.Text + "-";
            }

        }

        private void nummul_Click(object sender, EventArgs e)
        {
            if (Operation.Text != "")
            {
                Operation.Text = Operation.Text + "*";
            }
            else
            {
                Operation.Text = numscreen.Text + "*";
            }
        }

        private void numdiv_Click(object sender, EventArgs e)
        {
            if (Operation.Text != "")
            {
                Operation.Text = Operation.Text + "/";
            }
            else
            {
                Operation.Text = numscreen.Text + "/";
            }
        }
    }
}
