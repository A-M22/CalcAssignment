using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcAssignment
{
    
    public partial class Form1 : Form
    {
        double StoredValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            FieldBox.Text += "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FieldBox.Text = "0";
            ShowBox.Text = "0";
            StoredValue = 0;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            StoredValue = double.Parse(FieldBox.Text);
            ShowBox.Text = FieldBox.Text+" + ";
            FieldBox.Text = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double num = double.Parse(FieldBox.Text);
            char o = ShowBox.Text[ShowBox.Text.Length - 2];
            if (o == '+')
                StoredValue += num;
            else if (o == '-') 
                StoredValue -= num;
            else if (o == 'x') 
                StoredValue *= num;
            else if (o == '/')
            {
                if (FieldBox.Text == "0")
                    MessageBox.Show("Can't Devide by Zero!!");
                else
                    StoredValue /=num;
            }
            
            FieldBox.Text = StoredValue.ToString();
           // MessageBox.Show(StoredValue.ToString())

        }

        private void Divide_Click(object sender, EventArgs e)
        {

            StoredValue=double.Parse(FieldBox.Text); 
            ShowBox.Text = FieldBox.Text + " / ";
            FieldBox.Text="0";
        }

        private void Minos_Click(object sender, EventArgs e)
        {
            ShowBox.Text = FieldBox.Text+" - ";
            StoredValue=double.Parse(FieldBox.Text);
            FieldBox.Text="0";
        }

        private void Times_Click(object sender, EventArgs e)
        {
            StoredValue = double.Parse(FieldBox.Text);
            ShowBox.Text = FieldBox.Text + " x ";
            FieldBox.Text = "0";
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            int x = FieldBox.Text.Length - 1;
            if (x <=0)
                FieldBox.Text= "0";
            else
            FieldBox.Text=FieldBox.Text.Remove(x);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
