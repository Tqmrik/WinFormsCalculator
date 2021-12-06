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
        }

        private void _calculatorView_EqualButton(object sender, EventArgs e)
        {
            _calculatorView.OutputField = _mathHandler.EqualsOperation(_calculatorView.InputField);
        }
    }
}
