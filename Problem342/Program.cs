namespace Problem342;


public abstract class Program {

    public static void Main(string[] args)
    {
    }
    
    
    public bool IsPowerOfTwo(int n)
    {
        var x = Convert.ToDouble(n);
        double solution = Math.Log(x, 4);
        return solution % 1 == 0;
    }
}