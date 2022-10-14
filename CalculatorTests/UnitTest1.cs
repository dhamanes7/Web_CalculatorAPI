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
}
