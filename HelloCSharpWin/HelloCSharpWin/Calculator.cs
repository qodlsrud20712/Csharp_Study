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
    }
}
