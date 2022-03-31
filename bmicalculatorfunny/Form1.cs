using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmicalculatorfunny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //--get inputs
            string nameStr = nameEntry.Text;
            string weightStr = weightEntry.Text;
            string heightStr = heightEntry.Text;
            string ageStr = ageEntry.Text;
            //--gender
            string targetString = targetEntry.Text;

            //--convert user inputs to calculation inputs
            float weightFloat = weightStr;
            float heightFloat = heightStr;
            float targetFloat = targetString;

            //--calculate
            float bmi = weightFloat / (heightFloat * heightFloat);
            float targetDebt = bmi - targetFloat;
            string bmiClass = "ni-";

            //--convert to display information
            //range
            double boundDouble = 0;
            if (bmi < 18.5) { bmiClass = "underweight"; double boundDouble = 18.5; }
            else {
                if (bmi <= 24.9)
                {
                    double boundDouble = 25;
                    if (bmi <= 29.9)
                    {
                        if (bmi <= 39.9)
                        {
                            bmiClass = "obese class 2";
                        }
                        else { bmiClass = "obese class 1"; }
                    }
                    else { bmiClass = "overweight"; }
                }
                else { bmiClass = "healthyweight"; }
            }
            //delta
            float boundFloat = boundDouble.ToFloat();
            float weightDebt = Math.Sqrt(((boundDouble - bmi) * (heightFloat * heightFloat)) * ((boundDouble - bmi) * (heightFloat * heightFloat)));
            //string conversions
            string bmiStr = bmi.ToString();
            string weightDebtString = weightDebt.ToString();
            

            //--display
            textBox1.Text = (bmiStr);
            textBox2.Text = (bmiClass);
            textBox3.Text = (weightDebtString);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void weightMeasureKgTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
