namespace Calculator_3000
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
