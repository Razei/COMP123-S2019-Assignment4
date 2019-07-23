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
            InputFieldsInnerTableLayoutPanel.Visible = false;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            resetForm();
        }

        private void RadioButtonImperial_CheckedChanged(object sender, EventArgs e)
        {
            WeightLabel.Text = "My Weight (pounds)";
            HeightLabel.Text = "My Height (inches)";
            isMetric = false;
            InputFieldsInnerTableLayoutPanel.Visible = true;
        }

        private void RadioButtonMetric_CheckedChanged(object sender, EventArgs e)
        {
            WeightLabel.Text = "My Weight (kg)";
            HeightLabel.Text = "My Height (cm)";
            isMetric = true;
            InputFieldsInnerTableLayoutPanel.Visible = true;
        }

        /// <summary>
        /// This event handler closes any open instances of the keyboard and creates a new keyboard instance with a reference to HeightTextBox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxHeight_Click(object sender, EventArgs e)
        {
            _closeOpenForm("KeyboardForm");
            showKeyboard(HeightTextBox);
        }

        /// <summary>
        /// This event handler closes any open instances of the keyboard and creates a new keyboard instance with a reference to WeightTextBox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method checks for the specified form name and closes it if an instance exists already
        /// </summary>
        /// <param name="formName"></param>
        private static void _closeOpenForm(string formName)
        {
            //check for any open keyboard forms
            Form currentOpenForm = Application.OpenForms[formName];
            if (currentOpenForm != null)
            {
                currentOpenForm.Close();
            }
        }


        /// <summary>
        /// This event handler uses a different BMI formula when the RadioButton checked is Metric or Imperial, and outputs the result to the ResultTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculateButton_Click(object sender, EventArgs e)
        {
            double BMI = 0;
            double height = Convert.ToDouble(Program.calculatorForm.HeightTextBox.Text);
            double weight = Convert.ToDouble(Program.calculatorForm.WeightTextBox.Text);

            if (isMetric)
            {
                height = height / 100;
                BMI = weight / (height * height);
            }
            else if (!isMetric)
            {
                BMI = 703 * (weight / (height * height));
            }

            Program.calculatorForm.ResultTextBox.Text = Math.Round(BMI,1).ToString();
        }

        /// <summary>
        /// This method resets the form
        /// </summary>
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

        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
