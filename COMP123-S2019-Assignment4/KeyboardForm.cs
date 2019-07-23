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
    public partial class KeyboardForm : Form
    {
        // CLASS PROPERTIES
        public string outputString { get; set; }
        public bool decimalExists { get; set; }
        public double outputValue { get ; set; }

        /// <summary>
        /// This property holds the reference to the sender Textbox (the textbox currently in focus)
        /// </summary>
        public TextBox formSender { get; set; }

        public KeyboardForm()
        {
            InitializeComponent();          
        }

        /// <summary>
        /// This load event handler places the keyboard form to the right of the calculator form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyboardForm_Load(object sender, EventArgs e)
        {         
            this.Location = new Point(Program.calculatorForm.Location.X + 320, Program.calculatorForm.Location.Y + 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This click event handler validates and outputs the calculator button values to a the text property of the sender Textbox (the textbox currently in focus)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyboardButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();

            int buttonValue;
            bool resultCondition = int.TryParse(tag, out buttonValue);

            //if the user pressed a number button
            if (resultCondition)
            {
                int maxSize = 3;
                if (decimalExists)
                {
                    maxSize = 5;
                }

                if (outputString != "0" && formSender.Text.Count() < maxSize)
                {
                    outputString += tag;
                    formSender.Text = outputString;
                }
            }

            //if the user pressed a button that is not a number
            if (!resultCondition)
            {
                switch (tag)
                {
                    case "clear":
                        clearNumericKeyboard();
                        break;
                    case "done":
                        finalizeOutput();
                        break;
                    case "decimal":
                        addDecimalToformSender();
                        break;
                }
            }
        }

        /// <summary>
        /// This method adds a decimal to the formSender
        /// </summary>
        private void addDecimalToformSender()
        {
            if (!decimalExists)
            {
                if (formSender.Text == "0")
                {
                    outputString = "0";
                }
                outputString += ".";
                decimalExists = true;
            }
        }

        /// <summary>
        /// This method finalizes the calculation
        /// </summary>
        private void finalizeOutput()
        {
            if (outputString == string.Empty)
            {
                outputString = "0";
            }
            outputValue = float.Parse(outputString);
            formSender.Text = outputValue.ToString();
            clearNumericKeyboard();
        }

        /// <summary>
        /// This method clears the text property of the sender Textbox (the textbox currently in focus)
        /// </summary>
        private void clearNumericKeyboard()
        {
            formSender.Text = "0";
            outputString = String.Empty;
            decimalExists = false;
            outputValue = 0.0f;
        }
    }
}
