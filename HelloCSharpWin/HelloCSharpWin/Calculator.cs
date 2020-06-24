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


        private void Hellolabel_Click(object sender, EventArgs e)
        {
            int num1 = 10;
            int num2 = 11;

            int sum = num1 + num2;

            Hellolabel.Text = sum.ToString();
        }

        private void sum_btn_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(sum1.Text);
            int num2 = Convert.ToInt32(sum2.Text);
            int sum = Add(num1, num2);
            sum_res.Text = sum.ToString();

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
    }
}
