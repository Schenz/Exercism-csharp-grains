using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64) {
            throw new ArgumentOutOfRangeException();
        }

        return Convert.ToUInt64(Math.Pow(2, n-1));
    }

    public static ulong Total()
    {
        var value = 0UL;
        for (var index = 1; index < 65; index++){
            value += Square(index);
        }

        return value;
    }
}