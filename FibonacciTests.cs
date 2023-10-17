namespace FibonacciTests;

using FluentAssertions;
using NUnit.Framework;
using Fibonacci;

public class FibonacciTests
{
    [Test]
    public void TestBasicFibonacci()
    {
        var expectedOutputs = new int[]{1, 1, 2, 3, 5, 8, 13, 21, 34};
        for (int i = 0; i < expectedOutputs.Length; i++)
        {
            FibonacciCalculator.Calculate(i + 1).Should().Be(expectedOutputs[i]);
        }
    }

    [Test]
    public void TestFibonacciArray()
    {
        var startNumber = 3;
        var endNumber = 11;
        var expectedOutputs = new long[]{2, 3, 5, 8, 13, 21, 34, 55, 89};

        FibonacciCalculator.CalculateArray(startNumber, endNumber).Should().BeEquivalentTo(expectedOutputs);
    }
}