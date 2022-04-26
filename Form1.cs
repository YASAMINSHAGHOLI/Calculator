using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        ICalcutator CalculatorClass;
        public Form1()
        {
            InitializeComponent();
            CalculatorClass  = new CalculatorClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                int sum = CalculatorClass.Plus((int)txt1.Value, (int)txt2.Value);
                label2.Text = "Result =" + sum;
               // MessageBox.Show("Result =" + sum);//
            }
            
        }
        bool ValidateInputs()
        {
            bool isValid = true;
            if (txt1.Value==0 || txt2.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد را وارد کنید","اشکال",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {



                int Minus = CalculatorClass.Minus((int)txt1.Value, (int)txt2.Value);
                label2.Text = "Result =" + Minus;


            }

        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {

                int Multiple = CalculatorClass.Multiple((int)txt1.Value, (int)txt2.Value);
                label2.Text = "Result =" + Multiple;
            }

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {

                int Divide = CalculatorClass .Divide((int)txt1.Value, (int)txt2.Value);
                label2.Text = "Result =" + Divide;
            }

        }
    }
}
