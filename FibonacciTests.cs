namespace FibonacciTests;

using FluentAssertions;
using NUnit.Framework;

public class FibonacciTests
{
    [Test]
    public void TestBasicFibonacci()
    {
        var expectedOutputs = new int[]{1, 1, 2, 3, 5, 8, 13, 21, 34};
        for (int i = 0; i < expectedOutputs.Length; i++)
        {
            Fibonacci.FibonacciCalculator.Calculate(i + 1).Should().Be(expectedOutputs[i]);
        }
    }

    [Test]
    public void TestNullFibonacci()
    {
        Fibonacci.FibonacciCalculator.Calculate(null).Should().Be(1);
    }
}