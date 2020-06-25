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
            int num1 = 0;
            int num2 = 0;

            if (String.IsNullOrWhiteSpace(sum1.Text))
            {
                MessageBox.Show("sum1에 숫자 입력하시오.");
                sum1.Focus();
                return;
            }
            
            if(int.TryParse(sum1.Text, out num1) == false)
            {
                MessageBox.Show("sum1에 문자가 들어왔습니다.");
                sum1.SelectAll();
                sum1.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(sum2.Text))
            {
                MessageBox.Show("sum2에 숫자 입력하시오.");
                return;
            }


            if (int.TryParse(sum2.Text, out num2) == false)
            {
                MessageBox.Show("sum2에 문자가 들어왔습니다.");
                return;
            }

            //int.TryParse(string, out int)인데
            //여기서 string이 변환에 성공하면
            // out int에 값이 들어감.

            //num1 = Convert.ToInt32(sum1.Text);
            //num2 = Convert.ToInt32(sum2.Text);
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
