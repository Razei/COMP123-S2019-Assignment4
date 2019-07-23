using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4
{
    public partial class CalculatorForm : Form
    {
        public bool isMetric = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            resetForm();
        }

        private void RadioButtonImperial_CheckedChanged(object sender, EventArgs e)
        {
            isMetric = false;
        }

        private void RadioButtonMetric_CheckedChanged(object sender, EventArgs e)
        {
            isMetric = true;
        }

        private void TextBoxHeight_Click(object sender, EventArgs e)
        {
            _closeOpenForm("KeyboardForm");
            showKeyboard(HeightTextBox);
        }

        private void TextBoxWeight_Click(object sender, EventArgs e)
        {
            _closeOpenForm("KeyboardForm");
            showKeyboard(WeightTextBox);
        }

        /// <summary>
        /// This method shows the keyboard form and passes the reference of the textbox in focus
        /// </summary>
        public void showKeyboard(object sender)
        {           
            KeyboardForm keyboardForm = new KeyboardForm();
            keyboardForm.formSender = (TextBox)sender;
            keyboardForm.Show();
        }

        private static void _closeOpenForm(string formName)
        {
            //check for any open keyboard forms
            Form currentOpenForm = Application.OpenForms[formName];
            if (currentOpenForm != null)
            {
                currentOpenForm.Close();
            }
        }

        private void BMICalculateButton_Click(object sender, EventArgs e)
        {
            double BMI = 0;

            if (isMetric)
            {
                BMI = Convert.ToDouble(Program.calculatorForm.WeightTextBox.Text) / Math.Pow(Convert.ToDouble(Program.calculatorForm.HeightTextBox.Text), 2);
            }
            else if (!isMetric)
            {
                BMI = (Convert.ToDouble(Program.calculatorForm.WeightTextBox.Text) * 703) / Math.Pow(Convert.ToDouble(Program.calculatorForm.HeightTextBox.Text), 2);
            }

            Program.calculatorForm.ResultTextBox.Text = BMI.ToString();
        }

        private void resetForm()
        {
            this.HeightTextBox.Text = "0";
            this.WeightTextBox.Text = "0";
            this.ResultTextBox.Text = "0";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
