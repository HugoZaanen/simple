using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple
{
    public partial class Form1 : Form
    {
        double operand1, operand2, result;

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            result = operand1 - operand2;
            txtResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            result = operand1 * operand2;
            txtResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            result = operand1 / operand2;
            txtResult.Text = result.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            result = operand1 + operand2;
            txtResult.Text = result.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
