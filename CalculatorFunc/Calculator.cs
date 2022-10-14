namespace CalculatorFunc;
public class Calculator
{
    public static double Add(Double num1, double num2)
    {
        return num1 + num2;
    }
    public static double Subtract(Double num1, double num2)
    {
        return num1 - num2;
    }
    public static double Multiply(Double num1, double num2)
    {
        return num1 * num2;
    }
    public static double Division(Double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException();
        }
        else
        {
            return num1 / num2;
        }
        
    }

}

