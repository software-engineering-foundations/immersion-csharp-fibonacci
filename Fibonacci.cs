namespace Fibonacci;

public static class FibonacciCalculator {
    public static long Calculate(int position, bool isRecursive = false) 
    {
        if (isRecursive) 
        {
            return CalculateRecursive(position);
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

    private static long CalculateRecursive(int initialPosition, int? position = null, int left = 0, int right = 1) {
        var currentPosition = position ?? initialPosition;

        if (initialPosition == 0) 
        {
            return 0;
        }

        if (currentPosition == 0)
        {
            return left;
        }

        if (initialPosition > 0) 
        {
            return CalculateRecursive(initialPosition, currentPosition - 1, right, left + right);
        }
        else 
        {
            return CalculateRecursive(initialPosition, currentPosition + 1, right - left, left);
        }
    }
}