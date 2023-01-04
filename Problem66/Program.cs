namespace Problem66;

public abstract class Program {
    
    public static void Main(string[] args)
    {
    }
    
    public int[] PlusOne(int[] digits)
    {
        digits = digits.Select(x => x + 1).ToArray();
        return digits;

    }
    
}