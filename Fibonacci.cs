namespace Fibonacci;

public static class FibonacciCalculator {
    public static long Calculate(int position) 
    {
        if (position == 1 || position == 2)
        {
            return 1;
        }

        var smallFibonacciNumber = 1;
        var largeFibonacciNumber = 1;

        var currentPosition = 2;
        while(currentPosition < position) {
            var temp = smallFibonacciNumber;
            smallFibonacciNumber = largeFibonacciNumber;
            largeFibonacciNumber += temp;
            currentPosition++;
        }

        return largeFibonacciNumber;
    }
}