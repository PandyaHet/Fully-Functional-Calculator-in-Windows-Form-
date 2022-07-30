using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        
        String operation = "";
        Double result = 0;
        List<Double> Number = new List<Double>();
        List<string> Operator = new List<string>();

        public Form1()
        {
            InitializeComponent();

        }

        public void Result_value(object sender, EventArgs e)
        {
            Number.Add(Double.Parse(txtview.Text));
            result = Number[0];
            for (int i = 0; i < Operator.Count; i++)
            {
                switch (Operator[i])
                {
                    case "+":
                        txtview.Text = (result + Number[i + 1]).ToString();
                        result = Double.Parse(txtview.Text);
                        break;
                    case "-":
                        txtview.Text = (result - Number[i + 1]).ToString();
                        result = Double.Parse(txtview.Text);
                        break;
                    case "*":
                        txtview.Text = (result * Number[i + 1]).ToString();
                        result = Double.Parse(txtview.Text);
                        break;
                    case "/":
                        txtview.Text = (result / Number[i + 1]).ToString();
                        result = Double.Parse(txtview.Text);
                        break;
                }
            }
            lb1.Text = lb1.Text + " = " + result.ToString();
            //for (int i = 0; i < Number.Count; i++)
            //{
            //    lbview.Text = lbview.Text + "\n" + Number[i].ToString();

            //}
            //for (int j = 0; j < Operator.Count; j++)
            //{
            //    lboperator.Text = lboperator.Text + "\n" + Operator[j];

            //}

        }


        public void Numeric_value(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (txtview.Text.EndsWith("+") || txtview.Text.EndsWith("-") || txtview.Text.EndsWith("*") || txtview.Text.EndsWith("/") || txtview.Text.EndsWith("0"))
            {
                txtview.Text = button.Text;
            }
            else
            {
                txtview.Text = txtview.Text + button.Text;
            }
            lb1.Text = lb1.Text + button.Text;

        }

        private void Operator_value(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Number.Add(Double.Parse(txtview.Text));
            txtview.Text = button.Text;
            Operator.Add(button.Text);
            lb1.Text = lb1.Text + button.Text;
            operation = button.Text;

        }
        private void Clear(object sender, EventArgs e)
        {
            txtview.Text = "";
            lb1.Text = "";
            Number.Clear();
            Operator.Clear();
            //lboperator.Text = "";
            // lbview.Text = "";

        }
        private void Delete(object sender, EventArgs e)
        {

            if (txtview.Text.Length > 0)
            {
                txtview.Text = txtview.Text.Substring(0, txtview.Text.Length - 1);
                lb1.Text = lb1.Text.Substring(0, lb1.Text.Length - 1);
            }
            else
            {
                txtview.Text = "";
                lb1.Text = "";
            }
        }  
    }
}
