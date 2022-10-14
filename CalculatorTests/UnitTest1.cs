using System.Collections.Generic;
using CalculatorFunc;
namespace CalculatorTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow(3,4,7)]
    [DataRow(7.2, 5, 12.2)]
    [DataRow(9, -3, 6)]
    [DynamicData(nameof(GetNumbersToAdd),DynamicDataSourceType.Method)]
    public void AdditionTest(double num1, double num2, double expected)
    {
        var result = Calculator.Add(num1, num2);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(6, 4, 2)]
    [DataRow(7.2, 5, 2.2)]
    [DataRow(9, -3, 12)]
    [DynamicData(nameof(GetNumbersToSubtract), DynamicDataSourceType.Method)]
    public void SubtractionTest(double num1, double num2, double expected)
    {
        var result = Calculator.Subtract(num1, num2);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(6, 4, 24)]
    [DataRow(7.2, 5.4, 38.88)]
    [DataRow(9, -3, -27)]
    [DynamicData(nameof(GetNumbersToMultiply), DynamicDataSourceType.Method)]
    public void MultiplicationTest(double num1, double num2, double expected)
    {
        var result = Calculator.Multiply(num1, num2);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(8, 4, 2)]
    [DataRow(7.2, 5, 1.44)]
    [DataRow(-9, 3, -3)]
    [DynamicData(nameof(GetNumbersToDivide), DynamicDataSourceType.Method)]
    public void DivisionTest(double num1, double num2, double expected)
    {
        var result = Calculator.Division(num1, num2);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void DivisionByZeroTest()
    {
        Assert.ThrowsException<DivideByZeroException>(() => Calculator.Division(2, 0));
    }


    private static IEnumerable<Object[]> GetNumbersToAdd()
    {
        var list = new List<Object[]>();

        for (int i = 0; i < 10; i++)
        {
            Random random = new Random();
            var num1 = random.NextDouble();
            var num2 = random.NextDouble();
            var expected = Calculator.Add(num1, num2);
            list.Add(new Object[] { num1, num2, expected });

        }

        return list;
    }

    private static IEnumerable<Object[]> GetNumbersToSubtract()
    {
        var list = new List<Object[]>();

        for (int i = 0; i < 10; i++)
        {
            Random random = new Random();
            var num1 = random.NextDouble();
            var num2 = random.NextDouble();
            var expected = Calculator.Subtract(num1,num2);
            list.Add(new Object[] { num1, num2, expected });

        }

        return list;
    }

    private static IEnumerable<Object[]> GetNumbersToMultiply()
    {
        var list = new List<Object[]>();

        for (int i = 0; i < 10; i++)
        {
            Random random = new Random();
            var num1 = random.NextDouble();
            var num2 = random.NextDouble();
            var expected = Calculator.Multiply(num1,num2);
            list.Add(new Object[] { num1, num2, expected });

        }

        return list;
    }

    private static IEnumerable<Object[]> GetNumbersToDivide()
    {
        var list = new List<Object[]>();

        for (int i = 0; i < 10; i++)
        {
            Random random = new Random();
            var num1 = random.NextDouble();
            var num2 = random.NextDouble();
            if (num2 == 0)
            {
                num2 = 1;
            }
            var expected = Calculator.Division(num1,num2);
            list.Add(new Object[] { num1, num2, expected });

        }

        return list;
    }
}
