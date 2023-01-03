namespace Problem9;

public abstract class Program {
    
    public static void Main(string[] args)
    {
    }
    
    public bool IsPalindrome(int x)
    {
        var comparison = x;
        var reversed = 0;

        while (comparison != 0)
        {
            var digit = comparison % 10;
            reversed = reversed * 10 + digit;

            comparison /= 10;
        }

        if (x < 0)
        {
            return false;
        }
        else if (reversed == x)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}