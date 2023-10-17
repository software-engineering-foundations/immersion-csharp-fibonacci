namespace Fibonacci;

public static class FibonacciCalculator {
    public static long Calculate(int position) 
    {
        if (position == 0)
        {
            return 0;
        }

        if (position < 0)
        {
            return CalculateNegativeFibonacci(position);
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

    private static long CalculateNegativeFibonacci(int position)
    {
        if (position >= 0)
        {
            throw new ArgumentException("Position must be less than zero!");
        }

        var absoluteResult = Calculate(-position);
        return position % 2 == 0
            ? absoluteResult * -1
            : absoluteResult;
    }
}