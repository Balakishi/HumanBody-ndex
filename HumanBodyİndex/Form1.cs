using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanBodyİndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double h, w,result_bmi;
        private void button_result_Click(object sender, EventArgs e)
        {
            try { 

         //i did that in this if block, If you entered string, zero or you have not entered value you will notified by system
 if (!Double.TryParse(textBox_w.Text, out w) || !Double.TryParse(textBox_h.Text, out w) ||
 textBox_h.Text.Contains("-") || textBox_w.Text.Contains("-")|| textBox_h.Text == "0" || textBox_w.Text == "0")
            
            {
                DialogResult result = MessageBox.Show("The values of weight and height of human not be this value or you have not entered the value",
  "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            /* in this else blokc, if you not entered string, zero value application calculate BMI but there are two case: heigt 
             * maybe entered with cm and height entered with metr. Therefore, i write two case. My application calculate also two case. 
             * For example, you enterd 170cm heigt or 1,7 metr heigt. It calculate two case
             * 
             */
                else
                {
                    w = Convert.ToDouble(textBox_w.Text);
                    h = Convert.ToDouble(textBox_h.Text);
                    if (h < 3)
                    {
                        result_bmi = (double)((int)((w / Math.Pow(h, 2)) * 100)) / 100;
                        label_bmi.Text = Convert.ToString(result_bmi);
                    }
                    else
                    {
                        h = h / 100;
                        result_bmi = (double)((int)((w / Math.Pow(h, 2)) * 100)) / 100;
                        label_bmi.Text = Convert.ToString(result_bmi);
                    }
                    #region "Result block"
                    if (result_bmi < 18.5)
                    {
                        label_result.Text = "You are underweight";
                    }
                    else if (result_bmi > 18.5 && result_bmi < 24.9)
                    {
                        label_result.Text = "You are normal";
                    }
                    else if (result_bmi > 25 && result_bmi < 29.9)
                    {
                        label_result.Text = "You are overweight";
                    }
                    else if (result_bmi > 30 && result_bmi < 34.9)
                    {
                        label_result.Text = "You are obese";
                    }
                    else if (result_bmi > 35)
                    {
                        label_result.Text = "You are extremly obese";
                    }
                    #endregion
                }
            }
            catch
            {
                
            }
        }
    }
}
