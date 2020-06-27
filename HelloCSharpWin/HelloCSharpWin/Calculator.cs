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

        public int sub(int num1, int num2)
        {
            int sum = num1 - num2;
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
            Operation.Text = Operation.Text + "+";
        }

        private void result_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            string OperText;
            OperText = Operation.Text;
            //OperText.Replace("+-*/", "");
            string[] res = OperText.Split('+');
            int.TryParse(res[0], out num1);
            int.TryParse(res[1], out num2);
            int sum = Add(num1, num2);
            Operation.Text = "";
            numscreen.Text = sum.ToString();

        }
    }
}
