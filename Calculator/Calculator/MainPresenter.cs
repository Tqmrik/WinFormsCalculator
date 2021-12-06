using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathHandler;


namespace Calculator
{
    class MainPresenter
    {
        private readonly ICalculatorUI _calculatorView;
        private readonly IMathOperations _mathHandler;

        public MainPresenter(CalculatorUI calculatorView, MathOperations mathHandler)
        {
            _calculatorView = calculatorView;
            _mathHandler = mathHandler;


            _calculatorView.EqualButton += _calculatorView_EqualButton;
            _calculatorView.InputChanged += _calculatorView_InputChanged;
        }

        private void _calculatorView_InputChanged(object sender, EventArgs e)
        {
            _calculatorView.OutputField = _mathHandler.DynamicCalculations(_calculatorView.InputField);
        }

        private void _calculatorView_EqualButton(object sender, EventArgs e)
        {
            _calculatorView.InputField = _mathHandler.EqualsOperation(_calculatorView.InputField);
        }
    }
}
