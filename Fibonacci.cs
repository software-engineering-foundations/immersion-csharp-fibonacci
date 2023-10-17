namespace Fibonacci;

public static class FibonacciCalculator {
    public static long Calculate(int position) 
    {
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
}