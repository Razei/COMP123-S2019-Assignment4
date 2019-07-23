using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4
{
    static class Program
    {
        public static CalculatorForm calculatorForm;
        public static KeyboardForm keyboardForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            calculatorForm = new CalculatorForm();
            keyboardForm = new KeyboardForm();
            SplashForm splashForm = new SplashForm();

            Application.Run(splashForm);
        }
    }
}
