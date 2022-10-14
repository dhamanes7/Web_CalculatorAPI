namespace CalculatorFunc;
public class Calculator
{
    public static double Add(Double num1, double num2) //adding 2 numbers
    {
        return num1 + num2;
    }
    public static double Subtract(Double num1, double num2) //subtracting 2nd number from 1s1
    {
        return num1 - num2;
    }
    public static double Multiply(Double num1, double num2) // multipling 2 numbers
    {
        return num1 * num2;
    }
    public static double Division(Double num1, double num2) // dividing num1 by num2
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException(); //exception handled
        }
        else
        {
            return num1 / num2;
        }
        
    }

}

