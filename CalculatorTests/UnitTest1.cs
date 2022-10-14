using CalculatorFunc;
namespace CalculatorTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow(3,4,7)]
    [DataRow(7.2, 5.4, 12.6)]
    [DataRow(9, -3, 6)]
    public void AdditionTest(double num1, double num2, double expected)
    {
        var result = Calculator.Add(num1, num2);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(6, 4, 2)]
    [DataRow(7.2, 5.4, 1.8)]
    [DataRow(9, -3, 12)]
    public void SubtractionTest(double num1, double num2, double expected)
    {
        var result = Calculator.Subtract(num1, num2);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(6, 4, 24)]
    [DataRow(7.2, 5.4, 38.88)]
    [DataRow(9, -3, -27)]
    public void MultiplicationTest(double num1, double num2, double expected)
    {
        var result = Calculator.Multiply(num1, num2);
        Assert.AreEqual(expected, result);
    }
}
