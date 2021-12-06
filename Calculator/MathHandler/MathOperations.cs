using System;
using System.Collections.Generic;

namespace MathHandler
{
    public interface IMathOperations
    {
        public string EqualsOperation(string input);
        public int OperatorHandler(int firstNumber, string operat, int secondNumber);
        public string DynamicCalculations(string input);
    }
    public class MathOperations : IMathOperations
    {
        public string EqualsOperation(string input)
        {
            return input + " =";
        }

        public string DynamicCalculations(string input)
        {
            try
            {
                Queue<string> Inpt = new Queue<string>();
                foreach (string element in input.Split(' '))
                {
                    Inpt.Enqueue(element);
                }
                int result = int.Parse(Inpt.Dequeue());
                while(Inpt.Count != 0)
                {
                    switch (Inpt.Dequeue())
                    {
                        case "+":
                            result += int.Parse(Inpt.Dequeue());
                            break;
                        case "-":
                            result -= int.Parse(Inpt.Dequeue());
                            break;
                        case "*":
                            result *= int.Parse(Inpt.Dequeue());
                            break;
                    }
                }

                return result.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public int OperatorHandler(int firstNumber, string operat, int secondNumber)
        {
            switch (operat)
            {
                case "+":
                    return firstNumber + secondNumber;
            }
            return 0;
        }
    }
}
