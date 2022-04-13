using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Calculation
    {
        public static float Run(float firstOperand, float secondOperand, Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return firstOperand + secondOperand;                    
                case Operation.Substract:
                    return firstOperand - secondOperand;
                case Operation.Multiple:
                    return firstOperand * secondOperand;
                case Operation.Divide:
                    return firstOperand / secondOperand;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
