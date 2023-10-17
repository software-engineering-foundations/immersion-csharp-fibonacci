namespace Fibonacci;

public static class FibonacciCalculator {
    public static long Calculate(int position, bool recursion = false) 
    {
        if (recursion) 
        {
            return CalculateRecursive(1, 1, position - 2);
        }

        if (position <= 2)
        {
            return 1;
        }

        var i = 1;
        var j = 1;

        var currentPosition = 2;
        while(currentPosition < position) {
            var temp = i;
            i = j;
            j += temp;
            currentPosition++;
        }

        return j;
    }

    private static long CalculateRecursive(int previous, int current, int stepsLeft) 
    {
        if (stepsLeft < 0) 
        {
            return 1;
        }

        if (stepsLeft == 0) 
        {
            return current;
        }

        return CalculateRecursive(current, previous + current, stepsLeft - 1);
    }
}