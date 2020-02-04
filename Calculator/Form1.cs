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

        double first;
        double secondly;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClassSum objSum = new Clases.ClassSum();
        Clases.ClassSubst objSubst = new Clases.ClassSubst();
        Clases.ClassMult objMulti = new Clases.ClassMult();
        Clases.ClassDiv objDiv = new Clases.ClassDiv();

        private void BTN_0_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "0";
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "1";
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "2";
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "3";
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "4";
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "5";
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "6";
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "7";
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "8";
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + "9";
        }

        private void BTN_Coma_Click(object sender, EventArgs e)
        {
            TbxScreen.Text = TbxScreen.Text + ",";
        }

        private void BTN_Sum_Click(object sender, EventArgs e)
        {
            operation = "+";
            first = double.Parse(TbxScreen.Text);
            TbxScreen.Clear();
        }

        private void BTN_Substraction_Click(object sender, EventArgs e)
        {
            operation = "-";
            first = double.Parse(TbxScreen.Text);
            TbxScreen.Clear();
        }

        private void BTN_Multi_Click(object sender, EventArgs e)
        {
            operation = "*";
            first = double.Parse(TbxScreen.Text);
            TbxScreen.Clear();
        }

        private void BTN_Div_Click(object sender, EventArgs e)
        {
            operation = "/";
            first = double.Parse(TbxScreen.Text);
            TbxScreen.Clear();
        }

        private void BTN_Result_Click(object sender, EventArgs e)
        {
            secondly = double.Parse(TbxScreen.Text);

            double sum;
            double subst;
            double multi;
            double div;

            switch (operation)
            {
                case "+":
                    sum = objSum.Sumar(first, secondly);
                    TbxScreen.Text = sum.ToString();
                    break;

                case "-":
                    subst = objSubst.Restar(first, secondly);
                    TbxScreen.Text = subst.ToString();
                    break;

                case "*":
                    multi = objMulti.Multiplicacion(first, secondly);
                    TbxScreen.Text = multi.ToString();
                    break;

                case "/":
                    div = objDiv.Division(first, secondly);
                    TbxScreen.Text = div.ToString();
                    break;

            }
        }

        private void BTN_CE_Click(object sender, EventArgs e)
        {
            TbxScreen.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TbxScreen.Text.Length == 1)
                TbxScreen.Text = "";//cadena vacia
            else
                TbxScreen.Text = TbxScreen.Text.Substring(0, TbxScreen.Text.Length - 1);
        }
    }
}
