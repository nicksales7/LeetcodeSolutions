﻿namespace Problem231;


public abstract class Program {

    public static void Main(string[] args)
    {
    }
    
    
    public bool IsPowerOfTwo(int n)
    {
        var x = Convert.ToDouble(n);
        double solution = Math.Log2(x);
        return solution % 1 == 0;
    }
}