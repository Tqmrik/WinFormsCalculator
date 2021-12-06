using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathHandler;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CalculatorUI calculatorView = new CalculatorUI();
            MathOperations mathHandler = new MathOperations();
            MainPresenter mainPresenter = new MainPresenter(calculatorView, mathHandler);
        //Entry point for whole app, add your interfaces here and load its with your UI

            Application.Run(calculatorView);
        }
    }
}
