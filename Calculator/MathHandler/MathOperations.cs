using System;
using System.Collections.Generic;

namespace MathHandler
{
    public interface IMathOperations
    {
        public string EqualsOperation(string input);
        public int OperatorHandler(int firstNumber, string operat, int secondNumber);
    }
    public class MathOperations : IMathOperations
    {
        public string EqualsOperation(string input)
        {
            Queue<string> Inpt = new Queue<string>();
            foreach(string element in input.Split(' '))
            {
                Inpt.Enqueue(element);
            }
            int firstNumber = int.Parse(Inpt.Dequeue());
            string operat = Inpt.Dequeue();
            int secondNumber = int.Parse(Inpt.Dequeue());

            return OperatorHandler(firstNumber, operat, secondNumber).ToString();

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
