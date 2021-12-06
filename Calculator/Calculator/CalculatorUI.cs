using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public interface ICalculatorUI
    {
        string InputField { get; set; }
        string OutputField { get; set; }
        event EventHandler AdditionButton;
        event EventHandler EqualButton;
    }

    public partial class CalculatorUI : Form, ICalculatorUI
    {
        public CalculatorUI()
        {
            InitializeComponent();
            PlusButton.Click += PlusButton_Click;
            EqualsButton.Click += EqualsButton_Click;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            EqualButton?.Invoke(this, EventArgs.Empty);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            AdditionButton?.Invoke(this, EventArgs.Empty);
        }

        public string InputField
        {
            get { return InputBox.Text; }
            set { InputBox.Text = value; }
        }

        public string OutputField
        {
            get { return OutputBox.Text; }
            set { OutputBox.Text = value; }
        }

        public event EventHandler AdditionButton;
        public event EventHandler EqualButton;

    }
}
