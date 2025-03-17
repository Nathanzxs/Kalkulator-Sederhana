using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator1
{
    public partial class FormKalkulator : Form
    {
        private string operasi = "";
        private double temp = 0;
        private string strDisplay = "";
        private string stringDisplay = "";
        private bool isOn = false;

        public FormKalkulator()
        {
            InitializeComponent();
            ToggleButtons(false);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            stringDisplay += "1";
            textBoxDisplay.Text = stringDisplay;
        }


        private void buttonPM_Click(object sender, EventArgs e)
        {

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            stringDisplay += "0";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            stringDisplay += "1";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            stringDisplay += "2";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            stringDisplay += "3";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            stringDisplay += "4";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            stringDisplay += "5";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            stringDisplay += "6";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            stringDisplay += "7";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            stringDisplay += "8";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            stringDisplay += "9";
            textBoxDisplay.Text = stringDisplay;
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textBoxDisplay.Text);
            operasi = "+";
            strDisplay = "";
            textBoxDisplay.Clear();
            stringDisplay = "";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textBoxDisplay.Text);
            operasi = "-";
            strDisplay = "";
            textBoxDisplay.Clear();
            stringDisplay = "";

        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            temp = double.Parse(textBoxDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
            operasi = "*";
            strDisplay = "";
            textBoxDisplay.Clear();
            stringDisplay = "";
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textBoxDisplay.Text);
            operasi = "/";
            strDisplay = "";
            textBoxDisplay.Clear();
            stringDisplay = "";
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            isOn = !isOn;
            textBoxDisplay.Text = isOn ? "0" : "";
            ToggleButtons(isOn);
        }
        private void ToggleButtons(bool state)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Name != "buttonOnOff")
                {
                    btn.Enabled = state;
                }
            }
        }


        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            double hasil = 0.0;
            double currentValue = double.Parse(textBoxDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
            if (operasi == "+")
            {
                hasil = temp + Convert.ToDouble(textBoxDisplay.Text);
                strDisplay = hasil.ToString();
                textBoxDisplay.Text = strDisplay;
            }
            else if (operasi == "-")
            {
                hasil = temp - Convert.ToDouble(textBoxDisplay.Text);
                strDisplay = hasil.ToString();
                textBoxDisplay.Text = strDisplay;
            }
            else if (operasi == "*")
            {
                hasil = temp * Convert.ToDouble(textBoxDisplay.Text);
                strDisplay = hasil.ToString();
                textBoxDisplay.Text = strDisplay;
            }
            else if (operasi == "/")
            {
                hasil = temp / Convert.ToDouble(textBoxDisplay.Text);
                strDisplay = hasil.ToString();
                textBoxDisplay.Text = strDisplay;
            }

        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            temp = 0;
            operasi = "";
            stringDisplay = "";
            textBoxDisplay.Clear();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (stringDisplay.Length > 0)
            {
                stringDisplay = stringDisplay.Substring(0, stringDisplay.Length - 1);
                textBoxDisplay.Text = stringDisplay;
            }

        }

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
            if (!stringDisplay.Contains("."))
            {
                stringDisplay += ".";
                textBoxDisplay.Text = stringDisplay;
            }
        }
    }
}
